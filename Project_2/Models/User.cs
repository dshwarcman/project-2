using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Project_2.Models
{
    public class User
    {
        [Key]
        [Required]
        public int UserId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string PhoneNb { get; set; }
        public ICollection<Message> Messages { get; set; } = new List<Message>();
    }
}