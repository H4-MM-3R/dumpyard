using MiniDuckSimulator.FlyBehaviours;
using MiniDuckSimulator.QuackBehaviours;

namespace MiniDuckSimulator.Ducks;

public class RedHeadDuck : Duck
{
    public RedHeadDuck()
    {
        QuackBehaviour = new Quack();
        FlyBehaviour = new FlyWithWings();
    }

    public override void display()
    {
        Console.WriteLine("Looks like a RedHead");
    }
}
