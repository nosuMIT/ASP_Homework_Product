using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            ProductRepository products = new ProductRepository();
            return View(products);
        }
    }
}
