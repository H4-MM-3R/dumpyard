using PizzaStoreAbstractFactory.Ingredients;

namespace PizzaStoreAbstractFactory.Products.Ingredients;

public class FrozenClams : IClams
{
    public override string ToString()
    {
        return "Frozen Clams from Chesapeake Bay";
    }
}
