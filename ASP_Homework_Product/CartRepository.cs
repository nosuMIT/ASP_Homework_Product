using ASP_Homework_Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace ASP_Homework_Product
{
    public class CartRepository
    {
        private List<Cart> Carts = new List<Cart>();
        public Cart TryGetByUId(string userId)
        {
            return Carts.FirstOrDefault(x => x.UserId == userId);
        }

        public void Add(Product product, string userId)
        {
            var CartIsExist = TryGetByUId(userId);
            if(CartIsExist == null)
            {
                Cart newCart = new Cart()
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    CartItems = new List<CartItem>
                    {
                        new CartItem() {
                            Id = Guid.NewGuid(),
                            Product = product,
                            Amount = 1
                        }
                    }
                };
                Carts.Add(newCart);
            }
            else
            {
                CartItem CartItemIsExist = CartIsExist.CartItems.FirstOrDefault(pr => pr.Product.Id == product.Id);
                if (CartItemIsExist == null)
                {
                    CartIsExist.CartItems.Add(new CartItem()
                    {
                        Id = Guid.NewGuid(),
                        Product = product,
                        Amount = 1
                    });
                }
                else
                    CartItemIsExist.Amount++;
            }
        } 

    }
}
