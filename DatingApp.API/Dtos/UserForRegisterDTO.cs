using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 4, ErrorMessage = "Password must be between 4 - 12 characters")]
        public string Password { get; set; }
    }
}