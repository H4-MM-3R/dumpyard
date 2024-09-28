using PizzaStoreAbstractFactory.Ingredients;

namespace PizzaStoreAbstractFactory.Products.Ingredients;

public class ParmesanCheese : ICheese
{
    public override string ToString()
    {
        return "Shredded Parmesan";
    }
}
