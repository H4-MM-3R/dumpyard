using ChocolateBoiler.Boilers;

namespace ChocolateBoiler;

public class ChocolateBoiler
{
    private static BoilerType GetType(int a)
    {
        switch (a)
        {
            case 1:
                return ClassicBoiler.Instance;
            case 2:
                return StaticBoiler.Instance;
            case 3:
                return ThreadSafeBoiler.Instance;
            case 4:
                return DclBoiler.Instance;
            default:
                return ThreadSafeBoiler.Instance;
        }
    }

    public static void CheckInstance(int a)
    {
        BoilerType boiler = GetType(a);
        boiler.Status();
        boiler.Fill();
        boiler.Status();
        boiler.Boil();
        boiler.Status();
        boiler.Drain();
        boiler.Status();

        BoilerType boiler2 = GetType(a);
        boiler2.Status();

        Console.WriteLine(boiler == boiler2);
    }

    public static void CheckThreadSafety(int a)
    {
        var tasks = new List<Task>();

        tasks.Add(
            Task.Run(() =>
            {
                var boiler = GetType(a);
                boiler.Fill();
                boiler.Status();
            })
        );
        tasks.Add(
            Task.Run(() =>
            {
                var boiler = GetType(a);
                boiler.Fill();
                boiler.Boil();
                boiler.Drain();
                boiler.Status();
            })
        );

        Task.WaitAll(tasks.ToArray());
    }
}
