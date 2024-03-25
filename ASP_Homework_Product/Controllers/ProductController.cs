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
        private readonly IProductsRepository productsRepository;

        public ProductController(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        public IActionResult Index(int id)
        {
            Product requestedProduct = productsRepository.TryGetById(id);
            return View(requestedProduct);
        }
    }
}
