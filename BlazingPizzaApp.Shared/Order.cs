namespace BlazingPizzaApp.Shared
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();
        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}
