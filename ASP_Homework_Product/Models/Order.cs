﻿namespace ASP_Homework_Product.Models
{
    public class Order
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Cart Cart { get; set; }
    }
}
