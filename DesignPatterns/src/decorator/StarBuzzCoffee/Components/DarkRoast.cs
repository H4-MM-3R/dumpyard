using StarBuzzCoffee.Components.Impl;

namespace StarBuzzCoffee.Components;

public class DarkRoast : Beverage
{
    public DarkRoast()
    {
        Description = "Dark Roast";
    }

    public override double Price()
    {
       return .99; 
    }
}
