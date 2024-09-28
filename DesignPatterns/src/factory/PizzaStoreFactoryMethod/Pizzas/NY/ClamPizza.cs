using PizzaStoreFactoryMethod.Pizzas.Impl;

namespace PizzaStoreFactoryMethod.Pizzas.NY;

public class ClamPizza : Pizza
{
    public ClamPizza()
    {
        Name = "NY Style Clam Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";

        Ingredients.Add("Grated Reggiano Cheese");
        Ingredients.Add("Fresh Clams");
    }
}
