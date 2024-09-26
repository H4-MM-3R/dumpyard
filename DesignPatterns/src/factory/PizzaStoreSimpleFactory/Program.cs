using PizzaStoreSimpleFactory.Pizzas.Impl;

namespace PizzaStoreSimpleFactory;

internal class Program
{
    private static void Main(string[] args)
    {
        PizzaFactory pizzaFactory = new PizzaFactory();
        PizzaStore pizzaStore = new PizzaStore(pizzaFactory);

        Pizza pizza = pizzaStore.OrderPizza("cheese");

        pizza = pizzaStore.OrderPizza("veggie");

        pizza = pizzaStore.OrderPizza("clam");

        pizza = pizzaStore.OrderPizza("pepperoni");
    }
}
