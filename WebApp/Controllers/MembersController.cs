using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult TeamMembers()
        {
            return View();
        }
    }
}
