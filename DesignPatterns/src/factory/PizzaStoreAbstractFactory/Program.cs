using PizzaStoreAbstractFactory.Pizzas.Impl;
using PizzaStoreAbstractFactory.Stores;
using PizzaStoreAbstractFactory.Stores.Impl;

namespace PizzaStoreAbstractFactory;

internal class Program
{
    private static void Main(string[] args)
    {
        PizzaStore nyStore = new NYPizzaStore();
        PizzaStore chicagoStore = new ChicagoPizzaStore();
        Pizza pizza;

        pizza = nyStore.OrderPizza("cheese");
        pizza = nyStore.OrderPizza("pepperoni");
        pizza = nyStore.OrderPizza("veggie");
        pizza = nyStore.OrderPizza("clam");

        pizza = chicagoStore.OrderPizza("cheese");
        pizza = chicagoStore.OrderPizza("pepperoni");
        pizza = chicagoStore.OrderPizza("veggie");
        pizza = chicagoStore.OrderPizza("clam");
    }
}
