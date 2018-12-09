using Microsoft.AspNetCore.Identity;

namespace WebSecurity.Models
{
    public class ApplicationRole : IdentityRole
    {
        // definie le role
        public string Name { get; set; }
    }
}