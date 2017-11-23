using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory.Day2
{
    public abstract class Pizza
    {
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

    public class PortlandCheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing Portland - Cheese pizza.");
        }
    }

    public class PortlandClamPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing Portland - Clam pizza.");
        }
    }

    public class PortlandShoePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing Portland - Shoe pizza.");
        }
    }

    public class HillsboroCheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing Hillsboro - Cheese pizza.");
        }
    }

    public class HillsboroClamPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing Hillsboro - Clam pizza.");
        }
    }

    public class HillsboroShoePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing Hillsboro - Shoe pizza.");
        }
    }
}
