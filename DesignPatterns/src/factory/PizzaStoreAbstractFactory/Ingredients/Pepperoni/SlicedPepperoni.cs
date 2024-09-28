using PizzaStoreAbstractFactory.Ingredients;

namespace PizzaStoreAbstractFactory.Products.Ingredients;

public class SlicedPepperoni : IPepperoni
{
    public override string  ToString()
    {
        return "Sliced Pepperoni";
    }
}
