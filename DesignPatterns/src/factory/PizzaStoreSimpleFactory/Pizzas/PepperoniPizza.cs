using PizzaStoreSimpleFactory.Pizzas.Impl;

namespace PizzaStoreSimpleFactory.Pizzas;

public class PepperoniPizza : Pizza
{
public PepperoniPizza()
        {
            Name = "Pepperoni Pizza";
            Dough = "Crust";
            Sauce = "Marinara sauce";

            Ingredients.Add("Sliced Pepperoni");
            Ingredients.Add("Sliced Onion");
            Ingredients.Add("Grated parmesan cheese");
        }
}
