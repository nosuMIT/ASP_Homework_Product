using System;
using System.Collections.Generic;
using WebApplicationLesson1.Models;

namespace WebApplicationLesson1
{
	public class ProductRepository
	{
        private static List<Product> products = new List<Product>()
        {
            new Product("Last of us", 1000,"Sony's exclusive"),
            new Product("Red Dead Redemption 2", 2000, "Rockstar games"),
            new Product("Detroit",500,"Quantic Dream")
        };
        public List<Product> GetAllProducts()
        {
            return products;
        }
        public ProductRepository()
		{
		}
	}
}

