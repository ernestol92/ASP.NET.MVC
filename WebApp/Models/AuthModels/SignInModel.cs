using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.AuthModels 
{
    public class SignInModel
    {
        [Display(Name = "Email", Prompt = "Your email adress")]
        [Required(ErrorMessage = "You must enter an email adress")]
        [EmailAddress(ErrorMessage = "Please enter a valid email adress")]
        public string Email { get; set; } = null!;


        [Display(Name = "Password", Prompt = "Enter your password")]
        [Required(ErrorMessage = "You must enter a password")]
        public string Password { get; set; } = null!;

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; } = false;

    }
}

