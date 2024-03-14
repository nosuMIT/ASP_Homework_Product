using ASP_Homework_Product.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace ASP_Homework_Product.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var cart = CartRepository.TryGetByUId(Constants.UserId);
            return View(cart);
        }
        public IActionResult Add(int productId)
        {
            var product = ProductRepository.GetProduct(productId);
            CartRepository.Add(product, Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}
