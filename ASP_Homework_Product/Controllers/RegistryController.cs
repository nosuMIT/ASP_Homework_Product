using ASP_Homework_Product.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class RegistryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Enter(RegistryUser user)
        {
            if(ModelState.IsValid) return View(user);
            if (user.Login == user.Password) ModelState.AddModelError("", "Логин и пароль не должны совподать");
            return RedirectToAction("Index");
        }
    }
}
