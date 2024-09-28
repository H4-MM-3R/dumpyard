using PizzaStoreAbstractFactory.Pizzas.Impl;

namespace PizzaStoreAbstractFactory.Stores.Impl;

public abstract class PizzaStore
{
    protected abstract Pizza CreatePizza(string type);

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
