namespace StarBuzzCoffee.Components.Impl;

public abstract class Beverage
{
    public virtual string Description { get; protected set; } = "Unknown Beverage";

    public abstract decimal Price();

    public virtual Size size { get; set; } = Size.Tall;
}
