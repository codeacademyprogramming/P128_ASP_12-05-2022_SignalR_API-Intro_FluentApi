using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P224Allup.DAL;
using P224Allup.Models;
using Microsoft.AspNetCore.Identity;

namespace P224Allup.Hubs
{
    public class ChatHub : Hub
    {
        private readonly AllupDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ChatHub(AllupDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public override  Task OnConnectedAsync()
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                AppUser appUser = _userManager.FindByNameAsync(Context.User.Identity.Name).Result;

                appUser.ConnectionId = Context.ConnectionId;
                appUser.LastSeen = null;

                var result = _userManager.UpdateAsync(appUser).Result;

                Clients.All.SendAsync("setOnline", appUser.Id);
            }

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                AppUser appUser = _userManager.FindByNameAsync(Context.User.Identity.Name).Result;

                appUser.ConnectionId = null;
                appUser.LastSeen = DateTime.UtcNow.AddHours(4);

                var result = _userManager.UpdateAsync(appUser).Result;
                Clients.All.SendAsync("setOfline", appUser.Id);
            }

            return base.OnDisconnectedAsync(exception);
        }

        public async Task SendMessage(string id, string message)
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                AppUser fromUser = _userManager.FindByNameAsync(Context.User.Identity.Name).Result;

                AppUser toUser = _userManager.FindByIdAsync(id).Result;

                if (toUser != null && toUser.ConnectionId != null)
                {
                    await Clients.Client(toUser.ConnectionId).SendAsync("addi", fromUser.FullName, message);
                }

            }
        }
    }
}
