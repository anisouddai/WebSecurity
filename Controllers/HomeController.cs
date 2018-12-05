using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebSecurity.Helpers;
using WebSecurity.Models;
using WebSecurity.Services;

namespace WebSecurity.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;

        public HomeController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            IEmailSender emailSender,
            ILogger<AccountController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _emailSender = emailSender;
            _logger = logger;
        }
        
        [TempData]
        public string StatusMessage { get; set; }
        
        public async Task<IActionResult> Index()
        {
            // We check if the user's already logged in
            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (User != null)
            {
                RedirectToAction(nameof(Dashboard));
            }
            /*IActionResult redirectionAction = null;
            if (user != null)
            {
                // the user'll be redirected to a new page based on his role
                switch(user.Role)
                {
                    // customers are redirected to a manage account page
                    case RolesConstants.RESIDENTIALCUSTOMER:
                    case RolesConstants.BUSINESSCUSTOMER:
                        redirectionAction = RedirectToAction(nameof(CustomerHome));
                        break;
                    
                    // agents are redirected to a agent home page (displaying the 
                    // list of all business/residential users
                    case RolesConstants.BUSINESSCUSTOMER_AGENT:      
                    case RolesConstants.RESIDENTIALCUSTOMER_AGENT:
                        redirectionAction = RedirectToAction(nameof(AgentHome));
                        break;
                     
                    // admins are the shit
                    case RolesConstants.ADMIN:
                        redirectionAction = RedirectToAction(nameof(AdminHome));
                        break;
                            
                }
                return redirectionAction;
            }*/
            return View();
        }
        
        /*public IActionResult CustomerHome()
        {
            
            return RedirectToAction(nameof(ManageController.Index),"Manage");
        }
        
        public IActionResult AgentHome()
        {
            //todo: to be implemented
            ViewData["Message"] = "This page doesn't exist yet";
            return View();
        }
        
        public IActionResult AdminHome()
        {
            //todo: to be implemented
            ViewData["Message"] = "This page doesn't exist yet";
            return View();
        }*/
        
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        public IActionResult ComingSoon()
        {
            // Temp view to display shit
            return View();
        }
    }
}
