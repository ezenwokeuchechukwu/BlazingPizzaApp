// File: BlazingPizzaApp.Server/Data/OrderService.cs
using BlazingPizzaApp.Shared;

namespace BlazingPizzaApp.Server.Data
{
    public class OrderService
    {
        private readonly List<OrderWithStatus> _orders;

        // Constructor to initialize orders
        public OrderService()
        {
            _orders = new List<OrderWithStatus>();
        }

        // Get all orders
        public List<OrderWithStatus> GetAllOrders()
        {
            return _orders;
        }

        // Add a new order
        public void AddOrder(OrderWithStatus newOrder)
        {
            _orders.Add(newOrder);
        }
    }
}
