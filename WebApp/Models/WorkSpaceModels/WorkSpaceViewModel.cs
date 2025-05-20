using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApp.Models.WorkSpaceModels
{
    public class WorkSpaceViewModel
    {
        public AddProjectModel AddProject { get; set; } = new AddProjectModel();
        public EditProjectModel EditProject { get; set; } = new EditProjectModel();

        public List<SelectListItem> StatusOptions { get; set; } = new()
        {
            new SelectListItem { Text = "Not Started", Value = "1" },
            new SelectListItem { Text = "In Progress", Value = "2" },
            new SelectListItem { Text = "Completed", Value = "3" }
        };

        public bool ShowAddModal { get; set; } = false;
        public bool ShowEditModal { get; set; } = false;
    }
}
