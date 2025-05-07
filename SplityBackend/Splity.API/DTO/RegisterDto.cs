using System.ComponentModel.DataAnnotations;

namespace Splity.API.DTO
{
    public class RegisterDto
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }
        public string? Initials { get; set; }

        [Required]
        public string? Username { get; set; }

        [Required]
        [Phone]
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(20)]
        public string? Password { get; set; }
    }
}
