namespace MiniDuckSimulator.FlyBehaviours;

public class FlyRocketPowered : IFlyBehaviour
{
    void IFlyBehaviour.Fly()
    {
        Console.WriteLine("I'm flying with a rocket!");
    }
}
