﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P224Allup.DAL;
using P224Allup.Models;
using P224Allup.ViewModels.Home;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace P224Allup.Controllers
{
    public class HomeController : Controller
    {
        private readonly AllupDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(AllupDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {

            HomeVM homeVM = new HomeVM
            {
                Categories = await _context.Categories.Where(c => !c.IsDeleted && c.IsMain).ToListAsync(),
                NewArrival = await _context.Products.Where(p => !p.IsDeleted && p.IsNewArrival).ToListAsync(),
                Bestseller = await _context.Products.Where(p => !p.IsDeleted && p.IsBestseller).ToListAsync(),
                Featured = await _context.Products.Where(p => !p.IsDeleted && p.IsFeatured).ToListAsync()
            };
            return View(homeVM);
        }

        public async Task<IActionResult> Chat()
        {
            List<AppUser> users = await _userManager.Users.ToListAsync();

            return View(users);
        }
    }
}
