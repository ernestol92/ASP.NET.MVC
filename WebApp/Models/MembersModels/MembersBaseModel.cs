using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.MembersModels
{
    public abstract class MembersBaseModel
    {
        [Display(Name = "Firstname", Prompt = "Enter member firstname")]
        [Required(ErrorMessage = "Please enter members first name")]
        public string FirstName { get; set; } = null!;


        [Display(Name = "Lastname", Prompt = "Enter member lastname")]
        [Required(ErrorMessage = "Please enter members last name")]
        public string LastName { get; set; } = null!;


        [Display(Name = "Email", Prompt = "Enter member email")]
        [Required(ErrorMessage = "Please enter members email")]
        public string Email { get; set; } = null!;


        [Display(Name = "Phonenumber", Prompt = "Enter phonenumber")]
        [Required(ErrorMessage = "Please enter a phonenumber")]
        public string PhoneNumber { get; set; } = null!;


        [Display(Name = "Role", Prompt = "Enter member role")]
        [Required(ErrorMessage = "Please enter members role")]
        public string Role { get; set; } = null!;


        [Display(Name = "Address", Prompt = "Enter address")]
        [Required(ErrorMessage = "Please enter member address")]
        public string Address { get; set; } = null!;


        [Display(Name = "Birth date", Prompt = "Enter birth date")]
        [Required(ErrorMessage = "Please enter birth date")]
        public DateTime DateOfBirth { get; set; }
    }
}
