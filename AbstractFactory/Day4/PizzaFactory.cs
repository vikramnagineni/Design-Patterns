namespace Design_Patterns.AbstractFactory.Day4
{
    public abstract class PizzaStore
    {
        public PizzaType pizzaType { get; set; }
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
        public override Pizza CreatePizza()
        {
            if (pizzaType == PizzaType.Cheese)
            {
                return new PortlandCheesePizza();
            }
            else if (pizzaType == PizzaType.Clam)
            {
                return new PortlandClamPizza();
            }
            else
            {
                return new PortlandShoePizza();
            }
        }
    }

    public class HillsboroPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza()
        {
            if (pizzaType == PizzaType.Cheese)
            {
                return new HillsboroCheesePizza();
            }
            else if (pizzaType == PizzaType.Clam)
            {
                return new HillsboroClamPizza();
            }
            else
            {
                return new HillsboroShoePizza();
            }
        }
    }
}
