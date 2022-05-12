using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224DemoSignalR.Hubs
{
    public class P224Hub : Hub
    {
        //public async Task P224SendSerVer(string P224name, string P224Message)
        //{
        //    await Clients.All.SendAsync("P224ReciveClient", P224name, P224Message, DateTime.UtcNow.AddHours(4).ToString("dd.MM.yyyy HH:mm:ss:ffff"));
        //}

        public async Task JoinGroup(string connectionId, string groupName)
        {
            await Groups.AddToGroupAsync(connectionId, groupName);
        }


        public async Task P224SendSerVer(string P224name, string P224Message, string groupname)
        {
            await Clients.Group(groupname).SendAsync("P224ReciveClient", P224name, P224Message, DateTime.UtcNow.AddHours(4).ToString("dd.MM.yyyy HH:mm:ss:ffff"));
        }
    }
}
