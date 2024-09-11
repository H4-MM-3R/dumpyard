using StarBuzzCoffee.Components.Impl;

namespace StarBuzzCoffee.Decorators.Impl;

public abstract class Condiment : Beverage
{
    public abstract override string Description { get; }
}
