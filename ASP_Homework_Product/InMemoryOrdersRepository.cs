using ASP_Homework_Product.Models;
using System.Collections.Generic;

namespace ASP_Homework_Product
{
    public class InMemoryOrdersRepository : IOrderRepository
    {
        private List<Order> Orders = new List<Order>();
        public List<Order> GetOrders() { return Orders; }
        public void Add(Order order)
        {
            Orders.Add(order);
        }
    }

    public interface IOrderRepository
    {
        public List<Order> GetOrders();
        public void Add(Order order);
    }
}
