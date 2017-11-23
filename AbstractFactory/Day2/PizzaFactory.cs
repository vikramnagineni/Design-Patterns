namespace Design_Patterns.AbstractFactory.Day2
{
    public abstract class PizzaFactoryBase
    {
        public abstract Pizza OrderPizza(PizzaType pizzaType);
    }

    public class PizzaFactory: PizzaFactoryBase
    {
        // These are the issues with the following code.
        // 1. If a new type of pizza is added, we need to add one more else condition against open/closed principle.
        public override Pizza OrderPizza(PizzaType pizzaType)
        {
            Pizza pizza;
            if (pizzaType == PizzaType.Cheese)
            {
                pizza = new CheesePizza();
            }
            else if (pizzaType == PizzaType.Clam)
            {
                pizza = new ClamPizza();
            }
            else
            {
                pizza = new ShoePizza();
            }

            pizza.Create();
            return pizza;
        }
    }
}
