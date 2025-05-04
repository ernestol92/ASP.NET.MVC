namespace WebApp.Models
{
    public class WorkSpaceViewModel
    {
        public AddProjectModel AddProject { get; set; } = new AddProjectModel();
        public EditProjectModel EditProject { get; set; } = new EditProjectModel();

        public bool ShowAddModal { get; set; } = false;
        public bool ShowEditModal { get; set; } = false;
    }
}
