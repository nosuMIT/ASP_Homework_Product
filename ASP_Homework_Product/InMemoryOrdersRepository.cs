using ASP_Homework_Product.Models;
using System.Collections.Generic;

namespace ASP_Homework_Product
{
    public class InMemoryOrdersRepository : IOrderRepository
    {
        private List<Cart> Orders = new List<Cart>();
        public List<Cart> GetOrders() { return Orders; }
        public void Add(Cart order)
        {
            Orders.Add(order);
        }
    }

    public interface IOrderRepository
    {
        public List<Cart> GetOrders();
        public void Add(Cart order);
    }
}
