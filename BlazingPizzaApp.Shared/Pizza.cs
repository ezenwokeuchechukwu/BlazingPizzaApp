namespace BlazingPizzaApp.Shared
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Size { get; set; } = "Medium";
        public decimal Price { get; set; }
    }
}
