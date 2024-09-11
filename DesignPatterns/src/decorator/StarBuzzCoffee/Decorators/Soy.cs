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

    public override decimal Price()
    {
        return _beverage.Price()
            + _beverage.size switch
            {
                Size.Grande => 0.50m,
                Size.Venti => 0.75m,
                _ => 0.25m
            };
    }
}
