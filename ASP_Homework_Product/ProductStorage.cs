using System;
using System.Collections;
using System.Collections.Generic;
using ASP_Homework_Product.Models;

namespace ASP_Homework_Product
{
    public class ProductStorage/* : IEnumerable, IEnumerator*/
    {
        /*private int currentIndex = -1;*/
        private static List<Product> Products = new List<Product>()
        {
            new Product("Коленвал", 15000, "Коленчатый вал для Mercedes-Benz E500"),
            new Product("Поршни", 12000, "Облегченная поршневая система"),
            new Product("Бензонасос", 9000, "Улчушенный бензонасос")
        };

        public List<Product> GetProducts()
        {
            return Products;
        }

        

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

        /*public List<Product> ShowProducts()
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
            if (currentIndex >= Products.Count)
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }*/
    }
}
