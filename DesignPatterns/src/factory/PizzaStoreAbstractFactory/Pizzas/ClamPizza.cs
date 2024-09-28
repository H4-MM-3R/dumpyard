using PizzaStoreAbstractFactory.Factories.Impl;
using PizzaStoreAbstractFactory.Pizzas.Impl;

namespace PizzaStoreAbstractFactory.Pizzas;

public class ClamPizza : Pizza {
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public ClamPizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
        Name = "Clam Pizza";
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
        Clams = _ingredientFactory.CreateClams();
    }
}
