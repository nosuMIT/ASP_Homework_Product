﻿using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository productRepository;

        public ProductController() 
        {
            productRepository = new ProductRepository();
        }

        public IActionResult Index(int id)
        {
            var product = productRepository.TryGetById(id);

            return View(product);


        }
    }
}
