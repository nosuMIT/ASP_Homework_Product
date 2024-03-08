using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Homework_Product.Models
{
    public class Product
    {
        static int unicId = 0;
        public int Id { get; }
        public string Name { get; }
        public decimal Cost { get; }
        public string Description { get; }

        public Product(string name, decimal cost, string description)
        {
            unicId++;
            Id = unicId;
            Name = name;
            Cost = cost;
            Description = description;
        }

        public override string ToString()
        {
            return $"ID: {Id}\n{Name}\n{Cost} $";
        }
    }
}
