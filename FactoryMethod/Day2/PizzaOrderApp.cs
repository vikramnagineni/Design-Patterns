using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryMethod.Day2
{
    public enum PizzaType
    {
        Cheese = 1,
        Clam,
        Shoe
    }

    public static class PizzaOrderApp
    {
        public static void OrderPizza()
        {
            Console.WriteLine("Welcome!");
            PizzaType pizzaType;

            bool pizzaTypeSelected;
            do
            {
                Console.WriteLine("Please select pizza type");
                Console.WriteLine("1.Cheese");
                Console.WriteLine("2.Clam");
                Console.WriteLine("3.Shoe");
                pizzaTypeSelected = Enum.TryParse(Console.ReadLine(), out pizzaType);
                if (!pizzaTypeSelected)
                {
                    Console.WriteLine("That's an invalid entry. Try again.");
                }
            }
            while (!pizzaTypeSelected);

            Pizza pizza = CreatePizza(pizzaType);
            Console.WriteLine("Your pizza is ready");
            Console.ReadLine();
        }

        // These are the issues with the following method.
        // 1. If a new type of pizza is added, we need to add one more else condition against open/closed principle.

        // This following method is factory method.
        // Factory: A factory that creates objects that derive from a particular base class.
        // Better move this class to its own class to respect single responsibility.
        public static Pizza CreatePizza(PizzaType pizzaType)
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
