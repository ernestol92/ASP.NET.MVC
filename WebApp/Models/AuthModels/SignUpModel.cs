using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.AuthModels
{
    public class SignUpModel
    {
        [Required(ErrorMessage ="You must enter your full name (Firstname & Lastname)")]
        [Display(Name = "Full Name", Prompt ="Your full name")]
        public string FullName {get;set;} = null!;
        
        
        [Required(ErrorMessage ="You must enter an Email adress")]
        [Display(Name ="Email", Prompt = "Your email adress")]
        [EmailAddress(ErrorMessage = "Please enter a valid Email Adress")]
        public string Email { get; set; } = null!;
        
        
        [Required(ErrorMessage = "Password must contain atleast 8 characters and contain a special character")]
        [Display(Name = "Password", Prompt ="Enter your password")]
        public string Password { get; set; } = null!;
        
        
        [Required(ErrorMessage = "Passwords must match")]
        [Display(Name ="Confirm Password", Prompt = "Confirm your password")]
        public string ConfirmPassword { get; set; } = null!;

        [DisplayName("Terms and Conditions")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "You must accept the terms and conditions")]
        public bool TermsConditions { get; set; }
    }
}
