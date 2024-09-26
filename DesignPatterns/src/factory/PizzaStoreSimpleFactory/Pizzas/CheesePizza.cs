using PizzaStoreSimpleFactory.Pizzas.Impl;

namespace PizzaStoreSimpleFactory.Pizzas;

public class CheesePizza : Pizza
{
    public CheesePizza()
    {
        Name = "Cheese Pizza";
        Dough = "Regular Crust";
        Sauce = "Marinara Pizza Sauce";

        Ingredients.Add("Fresh Mozzarella");
        Ingredients.Add("Parmesan");
    }
}
