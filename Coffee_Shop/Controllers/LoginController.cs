using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop.Controllers
{

    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Authenticate(string Email, string Password)
        {
            if (Email == "admin@example.com" && Password == "password123")
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid login credentials!";
            return View("Index");
        }
    }

}

