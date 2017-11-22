using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory.Day3
{
    // This is solution to problem outlined in Day1
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

            Pizza pizza = new PizzaFactory().CreatePizza(pizzaType);
            Console.WriteLine("Your pizza is ready");
            Console.ReadLine();
        }
    }
}
