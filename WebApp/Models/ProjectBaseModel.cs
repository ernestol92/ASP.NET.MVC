using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public abstract class ProjectBaseModel
    {
        [Display(Name = "Project name", Prompt = "Enter project name")]
        [Required(ErrorMessage = "Please enter a Project Name")]
        public string ProjectName { get; set; } = null!;

        [Display(Name = "Client name", Prompt = "Enter client name")]
        [Required(ErrorMessage = "Please enter a Client Name")]
        public string ClientName { get; set; } = null!;

        [Display(Name = "Project description", Prompt = "Enter project description")]
        [Required(ErrorMessage = "Please enter a Project Description")]
        public string ProjectDescription { get; set; } = null!;

        [Required(ErrorMessage = "Please enter a Starting Date")]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "Please enter an Ending Date")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Budget", Prompt = "Enter a Budget")]
        [Required(ErrorMessage = "Please enter a Budget")]
        public int? Budget { get; set; }

        [Display(Name = "Status", Prompt = "Enter a status")]
        [Required(ErrorMessage = "Please enter a Status")]
        public int StatusId { get; set; }

        [Display(Name = "Member", Prompt = "Select a member")]
        [Required(ErrorMessage = "Please select a Member")]
        public int MemberId { get; set; }
    }
}
