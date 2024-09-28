using PizzaStoreFactoryMethod.Pizzas.Impl;

namespace PizzaStoreFactoryMethod.Pizzas.NY;

public class CheesePizza : Pizza
{
    public CheesePizza()
    {
        Name = "NY Style Cheese Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";

        Ingredients.Add("Grated Reggiano Cheese");
    }
}
