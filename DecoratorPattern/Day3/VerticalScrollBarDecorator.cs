using System;

namespace Design_Patterns.DecoratorPattern.Day3
{
    public class VerticalScrollBarDecorator: ComponentDecorator
    {
        public VerticalScrollBarDecorator(IComponent component)
            :base(component)
        {
        }

        public new void Draw()
        {
            this.ComponentToBeDecorated.Draw();
            DrawVerticalScrollbar();
        }

        private void DrawVerticalScrollbar()
        {
            Console.WriteLine("Draw vertical scrollbar");
        }
    }
}
