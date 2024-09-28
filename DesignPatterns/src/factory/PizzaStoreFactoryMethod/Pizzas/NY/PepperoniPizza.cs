using PizzaStoreFactoryMethod.Pizzas.Impl;

namespace PizzaStoreFactoryMethod.Pizzas.NY;

public class PepperoniPizza : Pizza
{
    public PepperoniPizza()
    {
        Name = "NY Style Pepperoni Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";

        Ingredients.Add("Grated Reggiano Cheese");
        Ingredients.Add("Sliced Pepperoni");
        Ingredients.Add("Garlic");
        Ingredients.Add("Onion");
        Ingredients.Add("Mushrooms");
    }
}
