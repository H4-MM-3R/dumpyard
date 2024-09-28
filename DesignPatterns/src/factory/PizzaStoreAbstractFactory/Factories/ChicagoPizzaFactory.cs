using PizzaStoreAbstractFactory.Factories.Impl;
using PizzaStoreAbstractFactory.Ingredients;
using PizzaStoreAbstractFactory.Products.Ingredients;

namespace PizzaStoreAbstractFactory.Factories;

public class ChicagoPizzaFactory : IPizzaIngredientFactory
{
    public ICheese CreateCheese()
    {
        return new MozzarellaCheese();
    }

    public IClams CreateClams()
    {
       return new FrozenClams(); 
    }

    public IDough CreateDough()
    {
       return new ThickCrustDough(); 
    }

    public IPepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public ISauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public IVeggies[] CreateVeggies()
    {
        return new IVeggies[] { new Onion(), new Mushroom(), new RedPepper() };
    }
}
