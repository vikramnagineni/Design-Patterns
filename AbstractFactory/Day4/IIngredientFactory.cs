using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory.Day4
{
    public interface IIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
    }

    public class Dough
    {
    }

    public class Sauce
    {
    }

    public class Cheese
    {
    }

    public class PortlandIngredientFactory : IIngredientFactory
    {
        public Dough CreateDough()
        {
            Console.WriteLine("Portland Ingredient Factory");
            return new Dough();
        }

        public Sauce CreateSauce()
        {
            Console.WriteLine("Portland Ingredient Factory");
            return new Sauce();
        }

        public Cheese CreateCheese()
        {
            Console.WriteLine("Portland Ingredient Factory");
            return new Cheese();
        }
    }

    public class HillsboroIngredientFactory : IIngredientFactory
    {
        public Dough CreateDough()
        {
            Console.WriteLine("Hillsboro Ingredient Factory");
            return new Dough();
        }

        public Sauce CreateSauce()
        {
            Console.WriteLine("Hillsboro Ingredient Factory");
            return new Sauce();
        }

        public Cheese CreateCheese()
        {
            Console.WriteLine("Hillsboro Ingredient Factory");
            return new Cheese();
        }
    }

}
