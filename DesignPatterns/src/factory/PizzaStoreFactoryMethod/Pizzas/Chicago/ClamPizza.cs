using PizzaStoreFactoryMethod.Pizzas.Impl;

namespace PizzaStoreFactoryMethod.Pizzas.Chicago;

public class ClamPizza : Pizza
{
    public ClamPizza()
    {
        Name = "Chicago Style Clam Pizza";
        Dough = "Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";

        Ingredients.Add("Mozzarella Cheese");
        Ingredients.Add("Frozen Clams");
    }

    public override void Cut() 
    {
        Console.WriteLine("Cutting the pizza to 4 Slices");
    }
}
