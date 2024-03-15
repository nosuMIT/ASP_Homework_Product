using ASP_Homework_Product.Models;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ASP_Homework_Product
{
    public class InMemoryProductcRepository : IProductRepository
    {
        private static List<Product> products = new List<Product>() {
                new Product("Death Stranding", 3990, "Какое-то описание","/images/DeathStranding.jpeg"),
                new Product("Days Gone", 2790, "Какое-то описание", "/images/DaysGone.jpg"),
                new Product("Infamous Secong son", 1600 , "Какое-то описание", "/images/InfamousSecondSon.jpg"),
                new Product("Red dead redemption 2", 3990 , "Какое-то описание", "/images/RDR2.jpeg"),
                new Product("God of war", 2990 , "Какое-то описание", "/images/GOW.webp")
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

    public interface IProductRepository
    {
        public Product GetProduct(int id);
        public List<Product> GetProducts();
    }
}
