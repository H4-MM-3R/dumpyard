using MiniDuckSimulator.FlyBehaviours;
using MiniDuckSimulator.QuackBehaviours;

namespace MiniDuckSimulator.Ducks;

public class DecoyDuck : Duck
{
    public DecoyDuck()
    {
        QuackBehaviour = new Silence();
        FlyBehaviour = new FlyNoWay();
    }

    public override void display()
    {
        Console.WriteLine("Looks like a DecoyDuck!");
    }
}
