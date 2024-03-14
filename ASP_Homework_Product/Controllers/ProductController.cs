using ASP_Homework_Product.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int id)
        {
            //ProductRepository catalog = new ProductRepository();
            Product product = ProductRepository.GetProduct(id);
            return View(product);
        }
    }
}
