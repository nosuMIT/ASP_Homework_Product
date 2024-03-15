using System.Collections.Generic;
using System.Linq;

namespace ASP_Homework_Product.Models
{
    public class Cart
    {
        public List<Product> ProductsInCart { get; set; }
        public decimal TotalCost 
        { 
            get 
            { 
                return ProductsInCart.Sum(product => product.Cost);
            } 
        }

        public Cart()
        {
            ProductsInCart = new List<Product>();
        }
    }
}
