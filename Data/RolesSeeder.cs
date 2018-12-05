using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using WebSecurity.Models;

namespace WebSecurity.Data
{
    public class RolesSeeder
    {
        private static readonly string[] _rolesList = 
        { "Administrator",
            "BusinessCustomer", 
            "ResidentialCustomer", 
            "BusinessCustomerAgent",
            "ResidentialCustomerAgent"
        };
        
        public static async Task Initialize(ApplicationDbContext context,
            RoleManager<IdentityRole> roleManager, ILogger<DbInitializer> logger)
        {
            // If Roles dbset has entities, we break
            if (context.Roles.Any())
            {
                return; // DB has been seeded
            }
    
            await CreateDefaultUserRoles(roleManager, logger);
        }
        
        private static async Task CreateDefaultUserRoles(RoleManager<IdentityRole> roleManager, ILogger<DbInitializer> logger)
        {
            foreach (var role in _rolesList)
            {
                // we create the role (remove the whitespaces before)
                await CreateDefaultRole(roleManager, logger, role.Trim().ToString());
            }
        }
        
        private static async Task CreateDefaultRole(RoleManager<IdentityRole> roleManager, ILogger<DbInitializer> logger, string role)
        {
            logger.LogInformation($"Create the role `{role}` for application");
            var identityResultr = await roleManager.CreateAsync(new IdentityRole(role));
            if (identityResultr.Succeeded)
            {
                logger.LogDebug($"Created the role `{role}` successfully");
            }
            else
            {
                var exception = new ApplicationException($"Default role `{role}` cannot be created");
                logger.LogError(exception, GetIdentiryErrorsInCommaSeperatedList(identityResultr));
                throw exception;
            }
        }
        
        private static string GetIdentiryErrorsInCommaSeperatedList(IdentityResult identityResult)
        {
            string errors = null;
            foreach (var identityError in identityResult.Errors)
            {
                errors += identityError.Description;
                errors += ", ";
            }
            return errors;
        }
    }
}