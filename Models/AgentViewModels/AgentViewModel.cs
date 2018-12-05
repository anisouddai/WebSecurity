using System.Collections.Generic;

namespace WebSecurity.Models.AgentViewModels
{
    public class AgentViewModel
    {
        public List<ApplicationUser> Users { get; set; }
        
        public string UsersRole { get; set; }
    }
}