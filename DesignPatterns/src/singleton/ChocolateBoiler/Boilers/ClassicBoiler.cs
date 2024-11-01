namespace ChocolateBoiler.Boilers;

public class ClassicBoiler : BoilerType
{
    private static ClassicBoiler? _instance;

    public static ClassicBoiler Instance => _instance ?? (_instance = new ClassicBoiler());

    private ClassicBoiler(){}

}
