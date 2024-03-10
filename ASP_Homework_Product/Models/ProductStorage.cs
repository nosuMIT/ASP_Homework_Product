using System;
using System.Collections;
using System.Collections.Generic;

namespace ASP_Homework_Product.Models
{
    public class ProductStorage : IEnumerable, IEnumerator
    {
        private int currentIndex = -1;
        static List<Product> Products = new List<Product>()
        {
            new Product("Коленвал", 15000, "Коленчатый вал для Mercedes-Benz E500"),
            new Product("Поршни", 12000, "Облегченная поршневая система"),
            new Product("Бензонасос", 9000, "Улчушенный бензонасос")
        };

        /*public bool CompareId(int id)
        {
            if (Products[currentIndex].Id == id)
            {
                return true;
            }
            else
            {
                return false;
            }
            foreach (var item in Products)
            {
                if (item.Id == id)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }*/

        public List<Product> ShowProducts()
        {
            return Products;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public object Current => Products[currentIndex];

        public bool MoveNext()
        {
            currentIndex++;
            if (currentIndex>= Products.Count)
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
