using PizzaStoreAbstractFactory.Factories.Impl;
using PizzaStoreAbstractFactory.Pizzas.Impl;

namespace PizzaStoreAbstractFactory.Pizzas;

public class VeggiePizza : Pizza {
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
        Name = "Veggie Pizza";
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
        Veggies = _ingredientFactory.CreateVeggies();
    }
}
