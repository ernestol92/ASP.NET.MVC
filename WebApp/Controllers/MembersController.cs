using Microsoft.AspNetCore.Mvc;
using WebApp.Models.MembersModels;

namespace WebApp.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult TeamMembers()
        {
            var membersViewModel = new MembersViewModel();
            return View(membersViewModel);
        }


        [HttpPost]
        public IActionResult TeamMembers(MembersViewModel formData) 
        {
            if (!ModelState.IsValid) 
            {
                formData.ShowAddModal = true;
                return View(formData);
            }

            return View(formData);
        }
    }
}
