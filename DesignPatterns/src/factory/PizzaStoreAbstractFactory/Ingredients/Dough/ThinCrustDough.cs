using PizzaStoreAbstractFactory.Ingredients;

namespace PizzaStoreAbstractFactory.Products.Ingredients;

public class ThinCrustDough : IDough
{
    public override string ToString()
    {
        return "Thin Crust Dough";
    }
}
