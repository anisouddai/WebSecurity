using Microsoft.AspNetCore.Identity;

namespace WebSecurity.Models
{
    public class ApplicationRole : IdentityRole
    {
        // defines (slight description) the Role
        public string Name { get; set; }
    }
}