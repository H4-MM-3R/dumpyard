using PizzaStoreAbstractFactory.Factories.Impl;
using PizzaStoreAbstractFactory.Pizzas.Impl;

namespace PizzaStoreAbstractFactory.Pizzas;

public class CheesePizza : Pizza {
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public CheesePizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
        Name = "Cheese Pizza";
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
    }
}
