namespace ChocolateBoiler.Boilers;

public class ThreadSafeBoiler : BoilerType
{
    private static readonly Lazy<ThreadSafeBoiler> lazy = new Lazy<ThreadSafeBoiler>(() => new ThreadSafeBoiler());

    public static ThreadSafeBoiler Instance => lazy.Value;

    private ThreadSafeBoiler() { }
}
