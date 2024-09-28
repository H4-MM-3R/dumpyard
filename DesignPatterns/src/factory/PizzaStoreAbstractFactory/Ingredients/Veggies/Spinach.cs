using PizzaStoreAbstractFactory.Ingredients;

namespace PizzaStoreAbstractFactory.Products.Ingredients;

public class Spinach : IVeggies
{
    public override string ToString()
    {
        return "Spinach";
    }
}
