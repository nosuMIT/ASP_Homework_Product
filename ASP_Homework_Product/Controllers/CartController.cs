using ASP_Homework_Product.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ASP_Homework_Product.Controllers
{
    public class CartController : Controller
    {

        ProductRepository products = new ProductRepository();
        static Cart cart;

        public CartController()
        {
            if (cart == null)
            {
                cart = new Cart();
            }
        }

        public IActionResult Index()
        {
            return View(cart);
        }

        public IActionResult AddToCart(int productId)
        {
            var product = products.TryGetById(productId);
            if(!cart.ProductsInCart.Contains(product))
            {
                cart.ProductsInCart.Add(product);
            }
            return RedirectToAction("Index", "Cart");
        }

        public IActionResult RemoveFromCart(int productId)
        {
            var product = products.TryGetById(productId);
            if (cart.ProductsInCart.Contains(product))
            {
                cart.ProductsInCart.Remove(product);
            }
            return RedirectToAction("Index", "Cart");
        }
    }
}
