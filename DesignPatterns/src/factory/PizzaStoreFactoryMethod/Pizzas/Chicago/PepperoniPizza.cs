using PizzaStoreFactoryMethod.Pizzas.Impl;

namespace PizzaStoreFactoryMethod.Pizzas.Chicago;

public class PepperoniPizza : Pizza
{
    public PepperoniPizza()
    {
        Name = "Chicago Style Pepperoni Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Plum Tomato Sauce";

        Ingredients.Add("Mozzarella Cheese");
        Ingredients.Add("Black Olives");
        Ingredients.Add("Spinach");
        Ingredients.Add("EggPlant");
        Ingredients.Add("Sliced Pepperoni");
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting the pizza to 4 Slices");
    }
}
