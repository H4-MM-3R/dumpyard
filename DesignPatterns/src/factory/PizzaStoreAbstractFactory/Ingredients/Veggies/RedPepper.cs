using PizzaStoreAbstractFactory.Ingredients;

namespace PizzaStoreAbstractFactory.Products.Ingredients;

public class RedPepper : IVeggies
{
    public override string ToString()
    {
        return "Red Pepper";
    }
}
