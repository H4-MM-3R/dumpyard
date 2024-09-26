using PizzaStoreSimpleFactory.Pizzas;
using PizzaStoreSimpleFactory.Pizzas.Impl;

namespace PizzaStoreSimpleFactory;

public class PizzaFactory
{
    public Pizza CreatePizza(string item)
    {
        Pizza pizza;
        switch (item)
        {
            case "cheese":
                pizza = new CheesePizza();
                break;
            case "veggie":
                pizza = new VeggiePizza();
                break;
            case "clam":
                pizza = new ClamPizza();
                break;
            case "pepperoni":
                pizza = new PepperoniPizza();
                break;
            default:
                pizza = new CheesePizza();
                break;
        }

        return pizza;
    }
}
