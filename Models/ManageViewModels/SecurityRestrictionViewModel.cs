using System.ComponentModel.DataAnnotations;

namespace WebSecurity.Models.ManageViewModels
{
    public class SecurityRestrictionViewModel
    {
        [Display(Name = "Tentatives d’authentification maximal")]
        public int NbTentatives { get; set; }

        [Display(Name = "Délais entre tentative échouée")]
        public int FailedLoginDelay { get; set; }

        [Display(Name = "Longueur")]
        public int RequiredLength { get; set; }

        [Display(Name = "Contient numéro")]
        public bool RequireDigit { get; set; }

        [Display(Name = "Contient caractère spéciaux")]
        public bool RequireNonAlphanumeric { get; set; }

        [Display(Name = "Contient majuscule")]
        public bool RequireUppercase { get; set; }

        [Display(Name = "Contient miniscule")]
        public bool RequireLowercase { get; set; }
    }
}
