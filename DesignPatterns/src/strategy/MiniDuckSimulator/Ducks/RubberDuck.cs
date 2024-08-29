using MiniDuckSimulator.FlyBehaviours;
using MiniDuckSimulator.QuackBehaviours;

namespace MiniDuckSimulator.Ducks;

public class RubberDuck : Duck
{
    public RubberDuck()
    {
        QuackBehaviour = new Squeak();
        FlyBehaviour = new FlyNoWay();
    }
    public override void display()
    {
        Console.WriteLine("Looks like a RubberDuck!");
    }
}
