using PizzaStoreSimpleFactory.Pizzas.Impl;

namespace PizzaStoreSimpleFactory.Pizzas;

public class VeggiePizza : Pizza 
{
    public VeggiePizza()
    {
        Name = "Veggie Pizza";
        Dough = "Crust";
        Sauce = "Marinara sauce";

        Ingredients.Add("Shredded mozzarella");
        Ingredients.Add("Grated parmesan");
        Ingredients.Add("Diced onion");
        Ingredients.Add("Sliced mushrooms");
        Ingredients.Add("Sliced red pepper");
        Ingredients.Add("Sliced black olives");
    }
}
