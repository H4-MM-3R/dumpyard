using System.Text;

namespace PizzaStoreSimpleFactory.Pizzas.Impl;

public abstract class Pizza
{
    public string? Name { get; set; }
    public string? Dough { get; set; }
    public string? Sauce { get; protected set; }

    public List<string> Ingredients { get; protected set; } = new List<string>();

    public virtual void Prepare()
    {
        Console.WriteLine("Preparing ...");
    }

    public virtual void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cutting the pizza");
    }

    public virtual void Box()
    {
        Console.WriteLine("Place pizza in box \n");
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine(Name);
        result.AppendLine($"Dough: {Dough}");
        result.AppendLine($"Sauce: {Sauce}");
        result.AppendLine($"Ingredients:");
        foreach (var topping in Ingredients)
        {
            result.AppendLine($"- {topping}");
        }

        return result.ToString();
    }
}
