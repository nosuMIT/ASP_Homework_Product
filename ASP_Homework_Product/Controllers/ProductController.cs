using ASP_Homework_Product.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductStorage productStorage;

        public ProductController()
        {
            productStorage = new ProductStorage();
        }

        public IActionResult Index(int id)
        {
            var products = productStorage.GetProducts();
            foreach (var product in products)
            {
                if (product.Id == id)
                {
                    return View(product);
                }
            }
            return View(products);
        }
    }
}
