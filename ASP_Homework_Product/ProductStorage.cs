﻿using System;
using System.Collections;
using System.Collections.Generic;
using ASP_Homework_Product.Models;

namespace ASP_Homework_Product
{
    public class ProductStorage/* : IEnumerable, IEnumerator*/
    {
        /*private int currentIndex = -1;*/
        public static List<Product> products = new List<Product>()
        {
            new Product("Коленвал", 15000, "Коленчатый вал для Mercedes-Benz E500", "Коленвал.jpeg"),
            new Product("Поршни", 12000, "Облегченная поршневая система", "Поршни.jpeg"),
            new Product("Бензонасос", 9000, "Улчушенный бензонасос", "Бензонасос.jpeg"),
            new Product("Компрессор", 50000, "Компрессор от М113", "Компрессор.jpeg"),
            new Product("Двигатель м113", 200000, "тяга бешенная", "Двигатель.jpeg")
        };

        public List<Product> GetProducts()
        {
            return products;
        }

        
    }
}
