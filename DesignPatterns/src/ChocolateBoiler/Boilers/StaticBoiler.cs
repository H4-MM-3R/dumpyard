namespace ChocolateBoiler.Boilers;

public class StaticBoiler : BoilerType
{
    public static StaticBoiler Instance { get; } = new StaticBoiler();

    private StaticBoiler() {}
}
