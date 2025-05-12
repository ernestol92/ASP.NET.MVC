using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult WorkSpace()
        {
            var viewModel = new WorkSpaceViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult WorkSpace(WorkSpaceViewModel formData) 
        {
            _logger.LogInformation("Form submitted: Project Name: {ProjectName}, Client Name: {ClientName}, Description: {ProjectDescription}",
                formData.AddProject?.ProjectName,
                formData.AddProject?.ClientName,
                formData.AddProject?.ProjectDescription);

            ModelState.Remove("EditProject.ProjectName");
            ModelState.Remove("EditProject.ClientName");
            ModelState.Remove("EditProject.ProjectDescription");
            ModelState.Remove("EditProject.StartDate");
            ModelState.Remove("EditProject.EndDate");
            ModelState.Remove("EditProject.Budget");
            if (formData.AddProject !=null)
            {
                if (!ModelState.IsValid) 
                {
                    formData.ShowAddModal = true;
                    return View(formData);
                }
            }
            
            formData.ShowAddModal = false;

            // TODO: Save to database here
            return View(formData);
        }

        [HttpPost]
        public IActionResult EditProject(WorkSpaceViewModel formData) 
        {
            ModelState.Remove("AddProject.ProjectName");
            ModelState.Remove("AddProject.ClientName");
            ModelState.Remove("AddProject.ProjectDescription");
            ModelState.Remove("AddProject.StartDate");
            ModelState.Remove("AddProject.EndDate");
            ModelState.Remove("AddProject.Budget");
            formData.ShowAddModal = false;
            if (formData.EditProject != null) 
            {
                if (!ModelState.IsValid) 
                {
                    formData.ShowEditModal = true;
                    return View("WorkSpace", formData);
                }

            }
                formData.ShowEditModal = false;
            return View("WorkSpace",formData);
        }
    }

    //streamline your controller
}
