using PizzaStoreAbstractFactory.Factories.Impl;
using PizzaStoreAbstractFactory.Ingredients;
using PizzaStoreAbstractFactory.Products.Ingredients;

namespace PizzaStoreAbstractFactory.Factories;

public class NYPizzaFactory : IPizzaIngredientFactory
{
    public ICheese CreateCheese()
    {
        return new ReggianoCheese();
        
    }

    public IClams CreateClams()
    {
        return new FreshClams();
        
    }

    public IDough CreateDough()
    {
        return new ThinCrustDough();
    }

    public IPepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
        
    }

    public ISauce CreateSauce()
    {
        return new MarinaraSauce();
        
    }

    public IVeggies[] CreateVeggies()
    {
        return new IVeggies[] { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
    }
}
