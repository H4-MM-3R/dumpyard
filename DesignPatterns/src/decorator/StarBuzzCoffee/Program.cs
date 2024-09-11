using StarBuzzCoffee.Components;
using StarBuzzCoffee.Components.Impl;
using StarBuzzCoffee.Decorators;

namespace StarBuzzCoffee;

internal class Program
{
    public static void Main(string[] args)
    {
        Beverage beverage = new Espresso();
        Console.WriteLine($"{beverage.Description} ${beverage.Price()}");

        Beverage beverage2 = new DarkRoast();
        beverage2 = new Mocha(beverage2);
        beverage2 = new Mocha(beverage2);
        beverage2 = new Whip(beverage2);
        Console.WriteLine($"{beverage2.Description} ${beverage2.Price()}");

        Beverage beverage3 = new HouseBlend();
        beverage3 = new Soy(beverage3);
        beverage3 = new Mocha(beverage3);
        beverage3 = new Whip(beverage3);
        Console.WriteLine($"{beverage3.Description} ${beverage3.Price()}");
    }

}
