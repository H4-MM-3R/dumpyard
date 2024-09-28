using PizzaStoreFactoryMethod.Pizzas.Impl;

namespace PizzaStoreFactoryMethod.Pizzas.NY;

public class VeggiePizza : Pizza
{
    public VeggiePizza()
    {
        Name = "NY Style Veggie Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";

        Ingredients.Add("Grated Reggiano Cheese");
        Ingredients.Add("Garlic");
        Ingredients.Add("Onion");
        Ingredients.Add("Mushrooms");
    }
}
