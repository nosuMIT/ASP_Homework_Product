﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASP_Homework_Product.Models;

namespace ASP_Homework_Product.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        List<Product> products = new List<Product>()
        {
            new Product("Коленвал", 15000, "Коленчатый вал для Mercedes-Benz E500"),
            new Product("Поршни", 12000, "Облегченная поршневая система"),
            new Product("Бензонасос", 9000, "Улчушенный бензонасос")
        };
        public string Index()
        {
            var result = "";
            foreach (var item in products)
            {
                result += item + "\n\n";
            }
            return result;



            /*ProductStorage product = new ProductStorage();
            return string.Join("\n\n", product.ShowProducts());*/


            //return product.ShowProducts();


            //return $"{product.ShowProducts()}";


            /*List<Product> products = new List<Product>()
            {
                new Product("Коленвал", 15000, "Коленчатый вал для Mercedes-Benz E500"),
                new Product("Поршни", 12000, "Облегченная поршневая система"),
                new Product("Бензонасос", 9000, "Улчушенный бензонасос")
            };

            ViewBag.Products = new List<Product>();

            foreach (var item in products)
            {
                ViewBag.Products.Add(item);
            }*/


            /*Product product = new Product("Коленвал", 15000, "Коленчатый вал для Mercedes-Benz E500");
            ViewBag.Product = product;
            Product secondProduct = */

            //return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
