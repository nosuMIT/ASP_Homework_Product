using System.Collections.Generic;

namespace ASP_Homework_Product.Models
{
    public class ProductStorage
    {
        List<Product> Products = new List<Product>()
        {
            new Product("Коленвал", 15000, "Коленчатый вал для Mercedes-Benz E500"),
            new Product("Поршни", 12000, "Облегченная поршневая система"),
            new Product("Бензонасос", 9000, "Улчушенный бензонасос")
        };

        public List<Product> ShowProducts()
        {
            return Products;
        }
    }
}
