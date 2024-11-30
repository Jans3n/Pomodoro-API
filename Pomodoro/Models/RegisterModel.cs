using System.ComponentModel.DataAnnotations;

namespace Pomodoro.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is require")]
        public string? Password { get; set; }
    }
}
