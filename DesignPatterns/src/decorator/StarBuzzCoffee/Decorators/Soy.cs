using StarBuzzCoffee.Components.Impl;
using StarBuzzCoffee.Decorators.Impl;

namespace StarBuzzCoffee.Decorators;

public class Soy : Condiment
{
    private readonly Beverage _beverage;

    public Soy(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override string Description => _beverage.Description + ", Soy";

    public override double Price()
    {
        return _beverage.Price() + 0.5;
    }
}
