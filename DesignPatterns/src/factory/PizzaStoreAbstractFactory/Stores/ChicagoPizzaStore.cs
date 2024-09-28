using PizzaStoreAbstractFactory.Factories;
using PizzaStoreAbstractFactory.Factories.Impl;
using PizzaStoreAbstractFactory.Pizzas;
using PizzaStoreAbstractFactory.Pizzas.Impl;
using PizzaStoreAbstractFactory.Stores.Impl;

namespace PizzaStoreAbstractFactory.Stores;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string item)
    {
        Pizza pizza;
        IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaFactory();

        switch (item)
        {
            case "cheese":
                pizza = new CheesePizza(ingredientFactory);
                break;

            case "veggie":
                pizza = new VeggiePizza(ingredientFactory);
                break;

            case "clam":
                pizza = new ClamPizza(ingredientFactory);
                break;

            case "pepperoni":
                pizza = new PepperoniPizza(ingredientFactory);
                break;

            default:
                pizza = new CheesePizza(ingredientFactory);
                break;
        }
        pizza.Name = $"Chicago Style {pizza.Name}";
        return pizza;
    }
}
