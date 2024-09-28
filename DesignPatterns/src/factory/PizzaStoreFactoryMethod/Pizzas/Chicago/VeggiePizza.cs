using PizzaStoreFactoryMethod.Pizzas.Impl;

namespace PizzaStoreFactoryMethod.Pizzas.Chicago;

public class VeggiePizza : Pizza
{
    public VeggiePizza()
    {
        Name = "Chicago Style Veggie Pizza";
        Dough = "Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";

        Ingredients.Add("Mozzarella Cheese");
        Ingredients.Add("Black Olives");
        Ingredients.Add("Spinach");
        Ingredients.Add("EggPlant");
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting the pizza to 4 Slices");
    }
}
