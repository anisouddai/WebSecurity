using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSecurity.Models.ManageViewModels
{
    public class IndexViewModel
    {
        [Display(Name = "Nom d'utilisateur")]
        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Adresse courriel")]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Numéro de téléphone")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}
