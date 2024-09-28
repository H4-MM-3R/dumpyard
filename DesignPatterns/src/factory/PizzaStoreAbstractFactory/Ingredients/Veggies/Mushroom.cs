using PizzaStoreAbstractFactory.Ingredients;

namespace PizzaStoreAbstractFactory.Products.Ingredients;

public class Mushroom : IVeggies
{
    public override string ToString()
    {
        return "Mushrooms";
    }
}
