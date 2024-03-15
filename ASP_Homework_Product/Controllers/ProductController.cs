using ASP_Homework_Product.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index(int id)
        {
            //ProductRepository catalog = new ProductRepository();
            Product product = _productRepository.GetProduct(id);
            return View(product);
        }
    }
}
