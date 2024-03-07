using ASP_Homework_Product.Models;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ASP_Homework_Product
{
    public class CatalogProducts
    {
        private static List<Product> products = new List<Product>() {
                new Product("Death Stranding", 3990, "Какое-то описание"),
                new Product("Days Gone", 2790, "Какое-то описание"),
                new Product("Infamous", 1600 , "Какое-то описание")
        };
        
        public Product GetProduct(int id)
        {
            foreach (Product p in products)
            {
                if (p.Id == id) return p;
            }
            return null;
        }
        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
