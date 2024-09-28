using PizzaStoreFactoryMethod.Pizzas.Impl;
using PizzaStoreFactoryMethod.Stores;
using PizzaStoreFactoryMethod.Stores.Impl;

namespace PizzaStoreFactoryMethod;

internal class Program
{
    private static void Main(string[] args)
    {
        PizzaStore nyStore = new NYPizzaStore();
        PizzaStore chicagoStore = new ChicagoPizzaStore();

        Pizza pizza = nyStore.OrderPizza("cheese");
        pizza = chicagoStore.OrderPizza("cheese");

        pizza = nyStore.OrderPizza("pepperoni");
        pizza = chicagoStore.OrderPizza("pepperoni");

        pizza = nyStore.OrderPizza("veggie");        
        pizza = chicagoStore.OrderPizza("veggie");

        pizza = nyStore.OrderPizza("clam");
        pizza = chicagoStore.OrderPizza("clam");


    }
}
