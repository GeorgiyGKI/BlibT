using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Repository.Configuration
{
    public class AdminSeeder
    {
        private readonly RepositoryContext _context;
        private readonly UserManager<User> _userManager;
        public AdminSeeder(RepositoryContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task Seed()
        {
            var userCheck = await _userManager.FindByEmailAsync("admin@test.com") == null;
            if (userCheck)
            {
                var admin = new User()
                {
                    UserName = "Admin",
                    Email = "admin@test.com",
                    Pocket = 1000
                };

                var moderator = new User()
                {
                    UserName = "moderator",
                    Email = "moderator@test.com",
                    Pocket = 1000
                };


                await _userManager.CreateAsync(admin, "TheAdm1n");
                await _userManager.CreateAsync(moderator, "TheM0derator");

                await _userManager.AddToRoleAsync(admin, "Administrator");
                await _userManager.AddToRoleAsync(moderator, "Moderator");
            }
        }
    }
}
