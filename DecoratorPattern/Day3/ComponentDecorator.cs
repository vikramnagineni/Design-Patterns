using System;

namespace Design_Patterns.DecoratorPattern.Day3
{
    public abstract class ComponentDecorator : IComponent
    {
        protected IComponent ComponentToBeDecorated{get;set;}
        public ComponentDecorator(IComponent component)
        {
            this.ComponentToBeDecorated = component;
        }

        public void Draw()
        {
            this.ComponentToBeDecorated.Draw();
        }

        public string GetDescription()
        {
            return this.ComponentToBeDecorated.GetDescription();
        }
    }
}
