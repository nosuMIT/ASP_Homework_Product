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
            var basket = BasketStorage.TryGetByUserId(Constants.UserId);
            return View(basket);
        }
        public IActionResult Add(int productId)
        {
            var product = productStorage.TryGetById(productId);
            BasketStorage.Add(product, Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}
