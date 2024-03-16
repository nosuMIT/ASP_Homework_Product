using ASP_Homework_Product.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP_Homework_Product.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductStorage productStorage;

        public ProductController()
        {
            productStorage = new ProductStorage();
        }

        public string Index(int id)
        {
            string result ="";
            List<Product> products = productStorage.GetProducts();

            foreach (Product product in products)
            {
                if (product.Id == id)
                {
                    result += product;
                }
                
            }
            if (result == "")
            {
                return $"Такого продукта по данному id нет!!!";
            }
            return result;
        }
    }
}
