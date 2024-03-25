using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            ProductsRepository products = new ProductsRepository();
            return View(products);
        }
    }
}
