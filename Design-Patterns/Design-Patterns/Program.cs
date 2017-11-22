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
            // Abstract Factory
            AbstractFactory.Day1.PizzaOrderApp.OrderPizza();
            AbstractFactory.Day2.PizzaOrderApp.OrderPizza();
            AbstractFactory.Day3.PizzaOrderApp.OrderPizza();
        }
    }
}
