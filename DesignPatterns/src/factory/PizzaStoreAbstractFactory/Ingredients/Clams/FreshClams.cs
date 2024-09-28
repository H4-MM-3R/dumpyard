using PizzaStoreAbstractFactory.Ingredients;

namespace PizzaStoreAbstractFactory.Products.Ingredients;

public class FreshClams : IClams
{
    public override string ToString()
    {
        return "Fresh Clams from Long Island Sound";
    }
}
