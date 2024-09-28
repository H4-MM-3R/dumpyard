using PizzaStoreAbstractFactory.Ingredients;

namespace PizzaStoreAbstractFactory.Products.Ingredients;

public class MozzarellaCheese : ICheese
{
    public override string ToString()
    {
        return "Mozzarella Cheese";
    }
}
