using BlazingPizzaApp.Shared;

namespace BlazingPizzaApp.Server.Data
{
    public class PizzaService
    {
        private readonly List<Pizza> _pizzas;

        public PizzaService()
        {
            _pizzas = new List<Pizza>
            {
                new Pizza { PizzaId = 1, Name = "Margherita", Price = 5.99M },
                new Pizza { PizzaId = 2, Name = "Pepperoni", Price = 6.99M },
                new Pizza { PizzaId = 3, Name = "Hawaiian", Price = 7.49M }
            };
        }

        // Return all pizzas
        public List<Pizza> GetPizzas()
        {
            return _pizzas;
        }

        // Return pizza by ID
        public Pizza GetPizzaById(int id)
        {
            return _pizzas.FirstOrDefault(p => p.PizzaId == id);
        }

        // Add a new pizza
        public void AddPizza(Pizza pizza)
        {
            // Automatically assign a new ID if not provided
            if (pizza.PizzaId == 0)
            {
                pizza.PizzaId = _pizzas.Max(p => p.PizzaId) + 1;
            }
            _pizzas.Add(pizza);
        }
    }
}
