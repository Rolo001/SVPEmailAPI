namespace Svp.Api.Controllers.Classes
{
    using System.ComponentModel.DataAnnotations;

    public class SignupRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(1)]
        public string Name { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }

        [Required]
        [MinLength(8)]
        [Compare(nameof(Password))]
        public string RepeatPassword {get; set;}
    }
}