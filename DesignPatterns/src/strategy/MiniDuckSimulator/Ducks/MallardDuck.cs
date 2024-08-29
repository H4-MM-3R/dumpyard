using MiniDuckSimulator.FlyBehaviours;
using MiniDuckSimulator.QuackBehaviours;

namespace MiniDuckSimulator.Ducks;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        QuackBehaviour = new Quack();
        FlyBehaviour = new FlyWithWings();
    }

    public override void display()
    {
        Console.WriteLine("I'm a MallardDuck");
    }
}
