using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// You can see below, we are solving problem with multiple factory methods.
// This might be the time to switch to Abstract factory pattern due to following locations.
// 1. Because lets assume there is some common code b/w following two methods. You want to move it to abstract base class. 
// 2. Assuming you are the owner of pizza stores, lets say irrespective of pizza store location, you want to define common process of creating pizzas. The you need to define your contracts in abstract base class. For more details, see abstract factory pattern
namespace Design_Patterns.FactoryMethod.Day5
{
    public class PortlandPizzaStore
    {
        // This following method is a factory method.
        // Factory: A factory that creates objects that derive from a particular base class.
        public Pizza OrderPizza(PizzaType pizzaType)
        {
            Pizza pizza;
            if (pizzaType == PizzaType.Cheese)
            {
                pizza = new PortlandCheesePizza();
            }
            else if (pizzaType == PizzaType.Clam)
            {
                pizza = new PortlandClamPizza();
            }
            else
            {
                pizza = new PortlandShoePizza();
            }
            return pizza;
        }
    }

    public class HillsboroPizzaStore
    {
        // This following method is a factory method.
        // Factory: A factory that creates objects that derive from a particular base class.
        public Pizza OrderPizza(PizzaType pizzaType)
        {
            Pizza pizza;
            if (pizzaType == PizzaType.Cheese)
            {
                pizza = new HillsboroCheesePizza();
            }
            else if (pizzaType == PizzaType.Clam)
            {
                pizza = new HillsboroClamPizza();
            }
            else
            {
                pizza = new HillsboroShoePizza();
            }
            return pizza;
        }
    }
}
