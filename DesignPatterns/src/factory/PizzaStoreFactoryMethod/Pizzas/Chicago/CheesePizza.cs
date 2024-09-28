using PizzaStoreFactoryMethod.Pizzas.Impl;

namespace PizzaStoreFactoryMethod.Pizzas.Chicago;

public class CheesePizza : Pizza
{
    public CheesePizza()
    {
        Name = "Chicago Style Cheese Pizza";
        Dough = "Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";

        Ingredients.Add("Mozzarella Cheese");
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting the pizza to 4 Slices");
    }

    

}
