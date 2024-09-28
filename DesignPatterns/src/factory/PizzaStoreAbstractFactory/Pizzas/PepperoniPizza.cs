using PizzaStoreAbstractFactory.Factories.Impl;
using PizzaStoreAbstractFactory.Pizzas.Impl;

namespace PizzaStoreAbstractFactory.Pizzas;

public class PepperoniPizza : Pizza {
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
        Name = "Pepperoni Pizza";
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
        Veggies = _ingredientFactory.CreateVeggies();
        Pepperoni = _ingredientFactory.CreatePepperoni();
    }
}
