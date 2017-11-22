using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory.Day2
{
    public enum PizzaStoreLocation
    {
        Portland = 1,
        Hillsboro
    }

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
            Console.WriteLine("Welcome !");
            PizzaStoreLocation pizzaStoreLocation;
            PizzaType pizzaType;

            bool pizzaStoreSelected;
            do
            {
                Console.WriteLine("Please select pizza store");
                Console.WriteLine("1.Portland");
                Console.WriteLine("2.Hillsboro");
                pizzaStoreSelected = Enum.TryParse(Console.ReadLine(), out pizzaStoreLocation);
                if (!pizzaStoreSelected)
                {
                    Console.WriteLine("That's an invalid entry. Try again.");
                }
            }
            while (!pizzaStoreSelected);

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
            // 2. If a new type of pizza store location is added, we need to add one more else condition against open/closed principle.
            Pizza pizza;
            if (pizzaStoreLocation == PizzaStoreLocation.Portland)
            {
                pizza = new PortlandPizza(pizzaType);
            }
            else
            {
                pizza = new Hillsboro(pizzaType);
            }

            pizza.Create();
            Console.WriteLine("Your pizza is ready");
            Console.ReadLine();
        }
    }
}
