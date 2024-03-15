using ASP_Homework_Product.Models;
using System.Collections.Generic;

namespace ASP_Homework_Product
{
    public class CartRepository
    {
        static List<Cart> ProductsInCart = new List<Cart>();

        public void AddCartToRepository(Cart cart)
        {
            ProductsInCart.Add(cart);
        }

        public void RemoveCartFromRepository(Cart cart)
        {
            ProductsInCart.Remove(cart);
        }
    }
}
