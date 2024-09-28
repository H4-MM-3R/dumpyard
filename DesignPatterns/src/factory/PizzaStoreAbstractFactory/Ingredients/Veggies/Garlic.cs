using PizzaStoreAbstractFactory.Ingredients;

namespace PizzaStoreAbstractFactory.Products.Ingredients;

public class Garlic : IVeggies
{
    public override string ToString()
    {
        return "Garlic";
    }
}
