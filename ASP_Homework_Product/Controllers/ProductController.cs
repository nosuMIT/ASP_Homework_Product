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
        public string Index(int id)
        {
            ProductRepository productRepository = new ProductRepository();
            Product requestedProduct = productRepository.TryGetById(id);
            return (requestedProduct == null) ? $"Нет товара со следующим id: {id}" : $"{requestedProduct}\n{requestedProduct.Description}";
        }
    }
}
