using PizzaStoreAbstractFactory.Ingredients;

namespace PizzaStoreAbstractFactory.Products.Ingredients;

public class PlumTomatoSauce : ISauce
{
    public override string ToString()
    {
        return "Tomato sauce with plum tomatoes";
    }
}
