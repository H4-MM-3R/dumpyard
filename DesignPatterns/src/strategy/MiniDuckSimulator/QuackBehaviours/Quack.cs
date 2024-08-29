namespace MiniDuckSimulator.QuackBehaviours;

public class Quack : IQuackBehaviour
{
    void IQuackBehaviour.Quack()
    {
        Console.WriteLine("Quack");
    }
}
