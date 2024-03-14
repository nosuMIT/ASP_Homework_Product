using ASP_Homework_Product.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace ASP_Homework_Product.Controllers
{
    public class CartController : Controller
    {
        private readonly ProductRepository _productRepository;
        private readonly CartRepository _cartRepository;
        private readonly Constants _constants;
        public CartController(ProductRepository productRepository, CartRepository cartRepository, Constants constants)
        {
            _productRepository = productRepository;
            _cartRepository = cartRepository;
            _constants = constants;
        }
        public IActionResult Index()
        {
            var cart = _cartRepository.TryGetByUId(_constants.UserId);
            return View(cart);
        }
        public IActionResult Add(int productId)
        {
            var product = _productRepository.GetProduct(productId);
            _cartRepository.Add(product, _constants.UserId);
            return RedirectToAction("Index");
        }
    }
}
