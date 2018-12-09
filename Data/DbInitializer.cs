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
         On s'assure que la Bdd existe avant de commencer le seeding process
       
         */
        public static async Task Initialize(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager, ILogger<DbInitializer> logger)
        {
            context.Database.EnsureCreated();

            
            if (!context.Roles.Any()) // 
            {
                // Initialisation du roleSeeder
                await RolesSeeder.Initialize(context, roleManager, logger);
                await UsersSeeder.Initialize(context, userManager, logger);
            }
            
        }
    }
}