using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory.Day2
{
    public abstract class Pizza
    {
        public PizzaType pizzaType { get; set; }
        public Pizza(PizzaType _pizzaType)
        {
            pizzaType = _pizzaType;
        }
        public void Create()
        {
            Prepare();
            Bake();
            Cut();
            Box();
        }
        public abstract void Prepare();
        public virtual void Bake()
        {
            Console.WriteLine("Baking pizza.");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting pizza.");
        }

        public virtual void Box()
        {
            Console.WriteLine("Packing pizza.");
        }
    }

    public class PortlandPizza : Pizza
    {
        public PortlandPizza(PizzaType pizzaType) : base(pizzaType)
        {

        }
        public override void Prepare()
        {
            if (pizzaType == PizzaType.Cheese)
            {
                Console.WriteLine("Preparing Portland - Cheese pizza.");
            }
            else if (pizzaType == PizzaType.Clam)
            {
                Console.WriteLine("Preparing Portland - Clam pizza.");
            }
            if (pizzaType == PizzaType.Shoe)
            {
                Console.WriteLine("Preparing Portland - Shoe pizza.");
            }
        }
    }

    public class Hillsboro : Pizza
    {
        public Hillsboro(PizzaType pizzaType) : base(pizzaType)
        {

        }
        public override void Prepare()
        {
            if (pizzaType == PizzaType.Cheese)
            {
                Console.WriteLine("Preparing Hillsboro - Cheese pizza.");
            }
            else if (pizzaType == PizzaType.Clam)
            {
                Console.WriteLine("Preparing Hillsboro - Clam pizza.");
            }
            if (pizzaType == PizzaType.Shoe)
            {
                Console.WriteLine("Preparing Hillsboro - Shoe pizza.");
            }
        }
    }
}
