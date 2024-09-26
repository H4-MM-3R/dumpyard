using PizzaStoreSimpleFactory.Pizzas.Impl;

namespace PizzaStoreSimpleFactory;

public class PizzaStore
{
    private PizzaFactory _pizzaFactory;

    public PizzaStore(PizzaFactory pizzaFactory)
    {
        _pizzaFactory = pizzaFactory;
    }

    public Pizza OrderPizza(string item)
    {
        Pizza pizza = _pizzaFactory.CreatePizza(item);
        Console.WriteLine($"Customer ordered a {pizza}");
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}
