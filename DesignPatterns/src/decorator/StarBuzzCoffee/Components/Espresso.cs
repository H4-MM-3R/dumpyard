using StarBuzzCoffee.Components.Impl;

namespace StarBuzzCoffee.Components;

public class Espresso : Beverage
{
    public Espresso()
    {
        Description = "Espresso";
    }

    public override decimal Price()
    {
        switch (size)
        {
            case Size.Grande:
                return 2.99m;
            case Size.Venti:
                return 3.99m;
        }
        return 1.99m;
    }
}
