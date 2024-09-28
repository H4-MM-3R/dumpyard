using PizzaStoreFactoryMethod.Pizzas.Impl;

namespace PizzaStoreFactoryMethod.Stores.Impl;

public abstract class PizzaStore
{
    protected abstract Pizza CreatePizza(string name);

    public Pizza OrderPizza(string type)
    {
        Pizza pizza = CreatePizza(type);
        Console.WriteLine($"Customer Ordered a {pizza}");
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        Console.WriteLine("========== DONE ===========\n");;

        return pizza;
    }

    
}
