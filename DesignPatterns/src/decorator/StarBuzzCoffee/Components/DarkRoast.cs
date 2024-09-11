using StarBuzzCoffee.Components.Impl;

namespace StarBuzzCoffee.Components;

public class DarkRoast : Beverage
{
    public DarkRoast()
    {
        Description = "Dark Roast";
    }

    public override decimal Price()
    {
        switch (size)
        {
            case Size.Grande:
                return 1.99m;
            case Size.Venti:
                return 2.99m;
        }
       return .99m; 
    }
}
