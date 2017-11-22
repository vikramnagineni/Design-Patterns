using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory.Day1
{
    public static class PizzaOrderApp
    {
        public static void OrderPizza()
        {
            Console.WriteLine("Welcome !");
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

            // These are the problems with following code.
            // 1. This method is doing many things against single responsiblity. This method is responsible for creating a  particular type of Pizza. Better pizza creation is delegated to someone else. The following code can get even more complex. Lets say we need pass different type of parameter to create different types of pizzas. Or we want to order pizza from different stores.
            // 2. Pizza creation code is not reusable.
            // 2. If a new type of pizza is added, we need to add one more else condition against open/closed principle.

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
            Console.WriteLine("Your pizza is ready");
            Console.ReadLine();
        }
    }
}
