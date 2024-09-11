using StarBuzzCoffee.Components.Impl;

namespace StarBuzzCoffee.Components;

public class Espresso : Beverage
{
    public Espresso()
    {
        Description = "Espresso";
    }

    public override double Price()
    {
        return 1.99;
    }
}
