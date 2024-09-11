using StarBuzzCoffee.Components.Impl;

namespace StarBuzzCoffee.Components;

public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        Description = "House Blend";
    }

    public override decimal Price()
    {
        switch (size)
        {
            case Size.Grande:
                return 1.89m;
            case Size.Venti:
                return 2.89m;
        }
        return .89m;
    }
}
