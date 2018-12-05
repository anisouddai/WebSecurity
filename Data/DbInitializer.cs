using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using WebSecurity.Models;

namespace WebSecurity.Data
{
    public class DbInitializer
    {
        /***
         * This method makes sure the DB was previously created
         * before starting the seeding process
         */
        public static async Task Initialize(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager, ILogger<DbInitializer> logger)
        {
            context.Database.EnsureCreated();

            // If both Roles and User contain entities, we break
            if (!context.Roles.Any()) // todo: add context.Users.Any())
            {
                // Initialize the RoleSeeder 
                await RolesSeeder.Initialize(context, roleManager, logger);
                await UsersSeeder.Initialize(context, userManager, logger);
            }
            
        }
    }
}