namespace MiniDuckSimulator.FlyBehaviours;

public class FlyWithWings : IFlyBehaviour
{
    void IFlyBehaviour.Fly()
    {
        Console.WriteLine("I'm flying with wings!");
    }
}
