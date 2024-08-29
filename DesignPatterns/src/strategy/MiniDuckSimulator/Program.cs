using MiniDuckSimulator.Ducks;
using MiniDuckSimulator.FlyBehaviours;
using MiniDuckSimulator.QuackBehaviours;

namespace MiniDuckSimulator;

public class Program
{
    public static void Main(string[] args)
    {
        Duck duck = new MallardDuck();

        // Duck duck = new RedHeadDuck();
        // Duck duck = new RubberDuck();

        duck.display();
         
        duck.performFly();
        duck.performQuack();

        duck.FlyBehaviour = new FlyRocketPowered();
        duck.QuackBehaviour = new Squeak();

        duck.performFly();
        duck.performQuack();

    }
 
}
