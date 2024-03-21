using ASP_Homework_Product.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class BasketController : Controller
    {
        private readonly ProductStorage productStorage;

        public BasketController()
        {
            productStorage = new ProductStorage();
        }

        public IActionResult Index()
        {
            BasketStorage.TryGetByUserId(Constants.UserId);
            return View();
        }
        public IActionResult Add(int id)
        {
            var product = productStorage.TryGetById(id);
            return View(product);
        }
    }
}
