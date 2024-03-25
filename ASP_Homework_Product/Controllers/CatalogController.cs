using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductsRepository productsRepository;

        public CatalogController(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        public IActionResult Index()
        {
            return View(productsRepository);
        }
    }
}
