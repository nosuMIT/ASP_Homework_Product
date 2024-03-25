using ASP_Homework_Product.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Homework_Product.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int id)
        {
            ProductsRepository productRepository = new ProductsRepository();
            Product requestedProduct = productRepository.TryGetById(id);
            return View(requestedProduct);
        }
    }
}
