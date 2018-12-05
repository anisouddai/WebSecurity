using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebSecurity.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Le prénom est requis.")]
        [Display(Name = "Prenom")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Le nom de famille est requis.")]
        [Display(Name = "Nom de famille")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "L'adresse courriel est requise.")]
        [EmailAddress]
        [Display(Name = "Adresse courriel")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Le {0} doit contenir entre {2} et {1} caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmez votre mot de passe")]
        [Compare("Password", ErrorMessage = "Les deux mots de passe ne concordent pas. Reessayez!")]
        public string ConfirmPassword { get; set; }
    }
}
