using BlazingPizzaApp.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazingPizzaApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly List<OrderWithStatus> _orders;

        public OrdersController(List<OrderWithStatus> orders)
        {
            _orders = orders;
        }

        [HttpGet]
        public IEnumerable<OrderWithStatus> Get() => _orders;

        [HttpPost]
        public ActionResult<OrderWithStatus> Post(OrderWithStatus order)
        {
            order.Order.OrderId = _orders.Count + 1;
            order.StatusText = "Pending";
            _orders.Add(order);
            return order;
        }
    }
}
