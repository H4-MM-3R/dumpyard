namespace ChocolateBoiler.Boilers;

public class DclBoiler : BoilerType
{
    private static volatile DclBoiler? _instance;
    private static readonly object _lock = new object();

    public static DclBoiler Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DclBoiler();
                    }
                }
            }
            return _instance;
        }
    }
    private DclBoiler() {}
}
