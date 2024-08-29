namespace MiniDuckSimulator.QuackBehaviours;

public class Squeak : IQuackBehaviour
{
    void IQuackBehaviour.Quack()
    {
        Console.WriteLine("Squeak");
    }
}
