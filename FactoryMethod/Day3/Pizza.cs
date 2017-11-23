﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryMethod.Day3
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

    public class CheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing Cheese pizza.");
        }
    }

    public class ClamPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing Clam pizza.");
        }
    }

    public class ShoePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing Shoe pizza.");
        }
    }    
}
