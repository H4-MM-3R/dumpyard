using System.Text;
using PizzaStoreAbstractFactory.Ingredients;

namespace PizzaStoreAbstractFactory.Pizzas.Impl;

public abstract class Pizza
{
        public string? Name { get; set; }

        public IDough? Dough { get; protected set; }
        public ISauce? Sauce { get; protected set; }
        public IVeggies[]? Veggies { get; protected set; }
        public ICheese? Cheese { get; protected set; }
        public IPepperoni? Pepperoni { get; protected set; }
        public IClams? Clams { get; protected set; }

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing ...");
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting pizza");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in box \n");
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(Name);
            if(Dough!= null) result.AppendLine($"Dough: {Dough.ToString()}");
            if(Sauce!= null) result.AppendLine($"Sauce: {Sauce.ToString()}");
            if(Cheese!= null) result.AppendLine($"Cheese: {Cheese.ToString()}");
            if(Pepperoni!= null) result.AppendLine($"Pepperoni: {Pepperoni.ToString()}");
            if(Clams!= null) result.AppendLine($"Clams: {Clams.ToString()}");
            if(Veggies != null)
            {
                result.AppendLine("Veggies: ");
                foreach(var veggie in Veggies)
                {
                    result.AppendLine($"- {veggie.ToString()}");
                }
            }

            return result.ToString();
        }
}
