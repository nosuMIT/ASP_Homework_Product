using ASP_Homework_Product.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int id)
        {
            CatalogProducts catalog = new CatalogProducts();
            Product product = catalog.GetProduct(id);
            return View(product);
        }
    }
}
