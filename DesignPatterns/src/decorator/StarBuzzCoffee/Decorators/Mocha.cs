using StarBuzzCoffee.Components.Impl;
using StarBuzzCoffee.Decorators.Impl;

namespace StarBuzzCoffee.Decorators;

public class Mocha : Condiment
{
    private readonly Beverage _beverage;

    public Mocha(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override string Description => _beverage.Description + ", Mocha";

    public override double Price()
    {
       return .15 + _beverage.Price();
    }
}
