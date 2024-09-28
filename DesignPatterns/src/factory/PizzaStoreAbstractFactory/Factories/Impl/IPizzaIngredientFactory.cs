using PizzaStoreAbstractFactory.Ingredients;

namespace PizzaStoreAbstractFactory.Factories.Impl;

public interface IPizzaIngredientFactory
{
    IDough CreateDough();
    ISauce CreateSauce();
    ICheese CreateCheese();
    IPepperoni CreatePepperoni();
    IClams CreateClams();
    IVeggies[] CreateVeggies();
}
