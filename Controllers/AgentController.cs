using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebSecurity.Data;
using WebSecurity.Helpers;
using WebSecurity.Models;
using WebSecurity.Models.AgentViewModels;
using WebSecurity.Services;

namespace WebSecurity.Controllers
{
    [Authorize(Roles = "ResidentialCustomerAgent,BusinessCustomerAgent,Administrator")]
    [Route("[controller]/[action]")]
    public class AgentController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _dbContext;

        public AgentController(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<ApplicationUser> signInManager,
            IEmailSender emailSender,
            ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _dbContext = dbContext;
        }
        
        // GET
        public async Task<IActionResult> Index()
        {
            //On vérifie que l'utilisateur soit loggé
            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (user != null)
            {
                List<ApplicationUser> users = new List<ApplicationUser>();
                String userRole = String.Empty;
                // Le préposé aux clients d'affaires peut voir les clients d'affaires 
                if (user.Role.Equals(RolesConstants.BUSINESSCUSTOMER_AGENT))
                {
                    userRole = "Clients d'affaire";
                    users = await _userManager.Users.Where(u => u.Role == RolesConstants.BUSINESSCUSTOMER).ToListAsync();
                }
            
                // Le préposé aux clients résidentiels peut voir les clients résidentiels 
                else if (user.Role.Equals(RolesConstants.RESIDENTIALCUSTOMER_AGENT))
                {
                    userRole = "Clients résidentiel";
                    users = await _userManager.Users.Where(u => u.Role == RolesConstants.RESIDENTIALCUSTOMER).ToListAsync();
                }
                
                // L'administrateur à accés à tout 
                else if (user.Role.Equals(RolesConstants.ADMIN))
                {
                    userRole = "Clients";
                    users = await _userManager.Users.ToListAsync();
                }
            
                return View(new AgentViewModel
                {
                    Users = users.OrderByDescending(u => u.Registered).ToList(),
                    UsersRole = userRole
                });
            }
            
            // Si l'utilisateur n'est pas loggé il est redirigé vers la page de d'acceuil
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}