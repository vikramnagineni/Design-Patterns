using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory.Day4
{
    // This is solution to problem outlined in Day2
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

            Pizza pizza;
            if (pizzaStoreLocation == PizzaStoreLocation.Portland)
            {
                pizza = new PortlandPizzaStore().OrderPizza(pizzaType);
            }
            else
            {
                pizza = new HillsboroPizzaStore().OrderPizza(pizzaType);
            }

            pizza.Create();
            Console.WriteLine("Your pizza is ready");
            Console.ReadLine();
        }
    }
}
