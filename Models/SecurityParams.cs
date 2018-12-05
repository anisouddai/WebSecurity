using System.ComponentModel.DataAnnotations;

namespace WebSecurity.Models
{
    public class SecurityParams : IModel
    {
        public int FailedLoginDelay { get; set; }
        public int Id { get; set; }
    }
}