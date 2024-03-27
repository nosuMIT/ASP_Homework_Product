using ASP_Homework_Product.Models;
using System.Collections.Generic;

namespace ASP_Homework_Product.Repositories
{
    public class MockProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>() {
            new Product(0, "Diamond", "-", 60),
            new Product(1, "Gold Ingot", "-", 25),
            new Product(2, "Iron Ingot", "-", 5),
        };
        public void Create(Product product)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> ReadAll()
        {
            return products;
        }

        public Product ReadById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
