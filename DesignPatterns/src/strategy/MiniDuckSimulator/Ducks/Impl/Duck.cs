using MiniDuckSimulator.FlyBehaviours;
using MiniDuckSimulator.QuackBehaviours;

namespace MiniDuckSimulator.Ducks;

public abstract class Duck
{
    public IFlyBehaviour? FlyBehaviour { get; set; }
    public IQuackBehaviour? QuackBehaviour { get; set; }

    protected Duck() { }

    public void swim() => Console.WriteLine("Swimming...");

    public abstract void display();

    public void performQuack() => QuackBehaviour?.Quack();

    public void performFly() => FlyBehaviour?.Fly();
}
