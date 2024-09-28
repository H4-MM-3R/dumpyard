using PizzaStoreAbstractFactory.Ingredients;

namespace PizzaStoreAbstractFactory.Products.Ingredients;

public class ThickCrustDough : IDough
{
    public override string ToString()
    {
        return "Thick Crust Dough";
    }
}
