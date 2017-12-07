using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factory Method Pattern
            FactoryMethod.Day1.PizzaOrderApp.OrderPizza();
            FactoryMethod.Day2.PizzaOrderApp.OrderPizza();
            FactoryMethod.Day3.PizzaOrderApp.OrderPizza();
            FactoryMethod.Day4.PizzaOrderApp.OrderPizza();

            // Abstract Factory Pattern
            AbstractFactory.Day1.PizzaOrderApp.OrderPizza();
            AbstractFactory.Day2.PizzaOrderApp.OrderPizza();
            AbstractFactory.Day3.PizzaOrderApp.OrderPizza();
            AbstractFactory.Day4.PizzaOrderApp.OrderPizza();

            // Adapter Pattern
            AdapterPattern.Day1.DocumentStorageServiceApp.Run();
            AdapterPattern.Day2.DocumentStorageServiceApp.Run();
            AdapterPattern.Day3.DocumentStorageServiceApp.Run();

        }
    }
}
