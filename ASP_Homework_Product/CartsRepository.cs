using ASP_Homework_Product.Models;
using System.Collections.Generic;
using System.Linq;

namespace ASP_Homework_Product
{
    public class CartsRepository
    {
        static List<Cart> carts = new List<Cart>();

        public static void AddCartToRepository(Cart cart)
        {
            carts.Add(cart);
        }

        public static void RemoveCartFromRepository(Cart cart)
        {
            carts.Remove(cart);
        }

        public static Cart TryGetCartByUserId(string userId)
        {
            return carts.FirstOrDefault(cart => cart.UserId == userId);
        }

        public static void AddToCart(Product product, string userId)
        {
            var cart = TryGetCartByUserId(userId);
            if(cart == null)
            {
                var newCart = new Cart {
                    UserId = userId,
                    ProductsInCart = new List<Product>()
                };
                AddCartToRepository(newCart);
                if (!newCart.ProductsInCart.Contains(product))
                {
                    newCart.ProductsInCart.Add(product);
                }
            }
            else
            {
                cart.ProductsInCart.Add(product);
                /*if (!cart.ProductsInCart.Contains(product))
                {
                    cart.ProductsInCart.Add(product);
                }*/
            }
        }

        public static void RemoveFromCart(Product product, string userId)
        {
            var cart = TryGetCartByUserId(userId);
            if (cart.ProductsInCart.Contains(product))
            {
                cart.ProductsInCart.Remove(product);
            }
        }
        public static void RemoveIdenticalFromCart(Product product, string userId)
        {
            var cart = TryGetCartByUserId(userId);
            if (cart.ProductsInCart.Contains(product))
            {
                cart.ProductsInCart.RemoveAll(prod => prod.Id == product.Id);
            }
        }
    }
}
