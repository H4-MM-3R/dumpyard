namespace ChocolateBoiler.Boilers;

public abstract class BoilerType
{
    public bool Empty { get; set; }
    public bool Boiled { get; set; }

    public BoilerType()
    {
        Empty = true;
        Boiled = false;
    }

    public void Fill()
    {
        if (Empty)
        {
            Console.WriteLine("==== Filling the boiler ====");
            Console.WriteLine();
            Empty = false;
            Boiled = false;
        }
    }

    public void Drain()
    {
        if (!Empty && Boiled)
        {
            Console.WriteLine("==== Draining the boiler ====");
            Console.WriteLine();
            Empty = true;
        }
    }

    public void Boil()
    {
        if (!Empty && !Boiled)
        {
            Console.WriteLine("==== Boiling the boiler ====");
            Console.WriteLine();
            Boiled = true;
        }
    }
    public void Status()
    {
        Console.WriteLine("Status:");
        Console.WriteLine($"- {(Empty ? "Empty" : "Full")}");
        Console.WriteLine($"- {(Boiled ? "Boiled" : "Cool")}");
        Console.WriteLine();
    }

    
}
