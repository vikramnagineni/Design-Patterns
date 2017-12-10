using System;

namespace Design_Patterns.DecoratorPattern.Day3
{
    public class HorizontalScrollBarDecorator:ComponentDecorator
    {
        public HorizontalScrollBarDecorator(IComponent component)
            :base(component)
        {
        }

        public new void Draw()
        {
            this.ComponentToBeDecorated.Draw();
            DrawHorizontalScrollbar();
        }

        private void DrawHorizontalScrollbar()
        {
            Console.WriteLine("Draw horizontal scrollbar");
        }
    }
}
