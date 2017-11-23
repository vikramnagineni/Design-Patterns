using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory.Day4
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
        IIngredientFactory ingredientFactory;

        public CheesePizza(IIngredientFactory customIngredientFactory)
        {
            this.ingredientFactory = customIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Cheese pizza.");
        }
    }

    public class ClamPizza : Pizza
    {
        IIngredientFactory ingredientFactory;

        public ClamPizza(IIngredientFactory customIngredientFactory)
        {
            this.ingredientFactory = customIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Clam pizza.");
        }
    }

    public class ShoePizza : Pizza
    {
        IIngredientFactory ingredientFactory;

        public ShoePizza(IIngredientFactory customIngredientFactory)
        {
            this.ingredientFactory = customIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Shoe pizza.");
        }
    }

    public abstract class PizzaStore
    {
        public PizzaType pizzaType { get; set; }
        public IIngredientFactory IngredientFactory { get; set; }
        public Pizza OrderPizza(PizzaType _pizzaType)
        {
            this.pizzaType = _pizzaType;
            var pizza = this.CreatePizza();
            pizza.Create();
            return pizza;
        }
        public abstract Pizza CreatePizza();
    }

    public class PortlandPizzaStore : PizzaStore
    {
        public PortlandPizzaStore()
        {
            this.IngredientFactory = new PortlandIngredientFactory();
        }
        public override Pizza CreatePizza()
        {
            if(pizzaType == PizzaType.Cheese)
            {
                return new CheesePizza(this.IngredientFactory);
            }
            else if(pizzaType == PizzaType.Clam)
            {
                return new ClamPizza(this.IngredientFactory);
            }
            else
            {
                return new ShoePizza(this.IngredientFactory);
            }
        }
    }

    public class HillsboroPizzaStore : PizzaStore
    {
        public HillsboroPizzaStore()
        {
            this.IngredientFactory = new HillsboroIngredientFactory();
        }

        public override Pizza CreatePizza()
        {
            if (pizzaType == PizzaType.Cheese)
            {
                return new CheesePizza(this.IngredientFactory);
            }
            else if (pizzaType == PizzaType.Clam)
            {
                return new ClamPizza(this.IngredientFactory);
            }
            else
            {
                return new ShoePizza(this.IngredientFactory);
            }
        }
    }
}
