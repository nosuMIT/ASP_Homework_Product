using ASP_Homework_Product.Models;
using System.Collections.Generic;

namespace ASP_Homework_Product.Repositories
{
    public interface IProductRepository
    {
        public Product ReadById(int id);
        public void Create(Product product);
        public List<Product> ReadAll();
    }
}
