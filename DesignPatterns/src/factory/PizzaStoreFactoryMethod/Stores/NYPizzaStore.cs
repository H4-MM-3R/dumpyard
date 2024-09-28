using PizzaStoreFactoryMethod.Pizzas.Impl;
using PizzaStoreFactoryMethod.Pizzas.NY;
using PizzaStoreFactoryMethod.Stores.Impl;

namespace PizzaStoreFactoryMethod.Stores;

public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string name)
    {
        Pizza pizza;
        switch (name)
        {
            case "cheese":
                pizza = new CheesePizza();
                break;
            case "pepperoni":
                pizza = new PepperoniPizza();
                break;
            case "veggie":
                pizza = new VeggiePizza();
                break;
            case "clam":
                pizza = new ClamPizza();
                break;
            default:
                pizza = new CheesePizza();
                break;
        }
        return pizza;
    }
}
