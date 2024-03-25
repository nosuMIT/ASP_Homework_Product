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
		public IActionResult Edit(int id)
		{
			Product product = _productRepository.GetProduct(id);
			return View(product);
		}

		public IActionResult Add()
		{
			return View();
		}

		public IActionResult Delete(int id)
		{
			_productRepository.Delete(id);
			return RedirectToAction("Products", "Admin");
		}


		[HttpPost]
		public IActionResult ChangeProductInfo(int id, string newName, decimal newCost)
		{
			_productRepository.ChangeProduct(id, newName, newCost);
			return RedirectToAction("Products","Admin");
		}

		[HttpPost]
		public IActionResult NewProduct(string newName, decimal newCost, string newDescription)
		{
			Product newProduct = new Product(newName, newCost, newDescription, "#");
			_productRepository.Add(newProduct);
			return RedirectToAction("Products", "Admin");
		}
	}
}
