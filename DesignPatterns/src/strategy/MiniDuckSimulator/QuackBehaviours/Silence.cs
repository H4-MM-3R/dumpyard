namespace MiniDuckSimulator.QuackBehaviours;

public class Silence : IQuackBehaviour
{
    void IQuackBehaviour.Quack()
    {
        Console.WriteLine("<< Silence >>");
    }
}
