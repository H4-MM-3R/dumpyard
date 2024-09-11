using StarBuzzCoffee.Components.Impl;

namespace StarBuzzCoffee.Components;

public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        Description = "House Blend";
    }

    public override double Price()
    {
        return .89;
    }
}
