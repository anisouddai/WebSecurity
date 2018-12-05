using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebSecurity.Models;

namespace WebSecurity.ViewComponents
{
    public class UserDashboardViewComponent : ViewComponent
    {
        protected readonly UserManager<ApplicationUser> _userManager;
        protected readonly SignInManager<ApplicationUser> _signInManager;
        protected readonly RoleManager<IdentityRole> _roleManager;
        
        public UserDashboardViewComponent(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, 
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ApplicationUser user = await _userManager.GetUserAsync(HttpContext.User);
            return View(user);
        }
    }
}