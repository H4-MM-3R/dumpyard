using PizzaStoreSimpleFactory.Pizzas.Impl;

namespace PizzaStoreSimpleFactory.Pizzas;

public class ClamPizza : Pizza
{
    public ClamPizza()
    {
        Name = "Clam Pizza";
        Dough = "Thin crust";
        Sauce = "White garlic sauce";

        Ingredients.Add("Clams");
        Ingredients.Add("Grated parmesan cheese");
    }
}
