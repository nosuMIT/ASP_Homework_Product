using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ASP_Homework_Product.Models;

namespace ASP_Homework_Product
{
    public static class BasketStorage
    {
        private static List<Basket> carts = new List<Basket>();

        public static Basket TryGetByUserId(string userId)
        {
            return carts.FirstOrDefault(x => x.UserId == userId);
        }
    }
}
