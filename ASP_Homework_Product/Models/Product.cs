using System;

namespace ASP_Homework_Product.Models
{
    public class Product
    {
        private static int unicId;
        public int Id { get; }
        public string Name { get; }
        public decimal Cost { get; }
        public string Description { get; }
        public string ImgLink;
        public Product(string name, decimal cost, string description, string imgLink)
        {
            Name = name;
            Cost = cost;
            Description = description;
            Id = unicId++;
            ImgLink = imgLink;
        }

        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Cost}\n";
        }

        
    }
}
