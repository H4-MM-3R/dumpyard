namespace ChocolateBoiler;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Chocolate Boiler ===");
        Console.WriteLine();
        Console.WriteLine("1. Classic Singleton");
        Console.WriteLine("2. Static Singleton");
        Console.WriteLine("3. Thread Safe Singleton");
        Console.WriteLine("4. Double Checked Locking Singleton");
        Console.WriteLine();
        Console.WriteLine("Enter Choice:");
        int choice = int.Parse("1");
        ChocolateBoiler.CheckInstance(choice);
        ChocolateBoiler.CheckThreadSafety(choice);
    }
}
