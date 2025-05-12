using Microsoft.AspNetCore.Mvc;
using WebApp.Models.AuthModels;

namespace WebApp.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult SignUp()
        {
            var signUpModel = new SignUpModel();
            return View(signUpModel);
        }

        [HttpPost]
        
        public IActionResult SignUp(SignUpModel model) {
        
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                return View(model);
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            var signInModel = new SignInModel();
            return View(signInModel);
        }

        [HttpPost]
        public IActionResult SignIn(SignInModel model)
        {
            if (!ModelState.IsValid) 
            {
                return View(model);
            }

            return View(model);
        }
    }
}
