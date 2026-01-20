namespace BlazingPizzaApp.Shared
{
    public class OrderWithStatus
    {
        public Order Order { get; set; } = new Order();
        public string StatusText { get; set; } = "Pending";
    }
}
