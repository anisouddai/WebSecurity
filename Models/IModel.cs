using System.ComponentModel.DataAnnotations;

namespace WebSecurity.Models
{
    public interface IModel
    {
        [Key]
        [Required]
        int Id { get; set; }
    }
}