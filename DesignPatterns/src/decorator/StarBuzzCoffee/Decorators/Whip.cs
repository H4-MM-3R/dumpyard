using StarBuzzCoffee.Components.Impl;
using StarBuzzCoffee.Decorators.Impl;

namespace StarBuzzCoffee.Decorators;

public class Whip : Condiment
{
    private readonly Beverage _beverage;

    public Whip(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override string Description => _beverage.Description + ", Whip";

    public override double Price()
    {
       return .15 + _beverage.Price();
    }
}
