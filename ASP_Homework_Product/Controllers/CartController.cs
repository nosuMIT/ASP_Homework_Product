using ASP_Homework_Product.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ASP_Homework_Product.Controllers
{
    public class CartController : Controller
    {

        ProductsRepository products;

        public CartController()
        {
            products = new ProductsRepository();
        }

        public IActionResult Index()
        {
            Cart cart = CartsRepository.TryGetCartByUserId(Constants.UserId);
            return View(cart);
        }

        public IActionResult Add(int productId)
        {
            var product = products.TryGetById(productId);
            CartsRepository.AddToCart(product, Constants.UserId);
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int productId)
        {
            var product = products.TryGetById(productId);
            CartsRepository.RemoveFromCart(product, Constants.UserId);
            return RedirectToAction("Index");
        }
        public IActionResult RemoveAll(int productId)
        {
            var product = products.TryGetById(productId);
            CartsRepository.RemoveIdenticalFromCart(product, Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}
