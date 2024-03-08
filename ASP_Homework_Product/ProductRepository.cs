using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Homework_Product.Models;

namespace ASP_Homework_Product
{
    public class ProductRepository
    {
        static List<Product> Products = new List<Product>
        {
            new Product("Elden ring", Convert.ToDecimal(49.89), "game1"),
            new Product("Minecraft", Convert.ToDecimal(29.99), "game2"),
            new Product("Cyberpunk 2077", Convert.ToDecimal(35.49), "game3")
        };

        public List<Product> GetProducts()
        {
            return Products;
        }

        public Product TryGetById(int id)
        {
            return Products.FirstOrDefault(product => product.Id == id);
        }
    }
}
