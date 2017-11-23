using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryMethod.Day3
{
    public class PizzaFactory
    {
        // These are the issues with following code.
        // 1. If a new type of pizza is added, we need to add one more else condition against open/closed principle.

        // This following method is factory method.
        // Factory: A factory that creates objects that derive from a particular base class.
        public Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza;
            if (pizzaType == PizzaType.Cheese)
            {
                pizza = new CheesePizza();
            }
            else if (pizzaType == PizzaType.Clam)
            {
                pizza = new ClamPizza();
            }
            else
            {
                pizza = new ShoePizza();
            }

            pizza.Create();
            return pizza;
        }
    }
}
