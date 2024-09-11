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

    public override decimal Price()
    {
        return _beverage.Price()
            + _beverage.size switch
            {
                Size.Grande => 0.30m,
                Size.Venti => 0.45m,
                _ => 0.15m
            };
    }
}
