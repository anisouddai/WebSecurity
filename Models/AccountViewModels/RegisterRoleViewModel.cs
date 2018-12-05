using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebSecurity.Models.AccountViewModels
{
    public class RegisterRoleViewModel
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        
        public string ConfirmPassword { get; set; }
        public string SelectedRole { set; get; }
        
        public List<SelectListItem> RolesList => new List<SelectListItem>()
        {
            new SelectListItem {Text = "Préposé aux clients résidentiels", Value = "ResidentialCustomerAgent"},
            new SelectListItem {Text = "Préposé aux clients d'affaires", Value = "BusinessCustomerAgent"},
            new SelectListItem {Text = "Administrateur", Value = "Administrator"}
        };
    }
}
