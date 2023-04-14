using System.ComponentModel.DataAnnotations;

namespace SammourProfile.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
