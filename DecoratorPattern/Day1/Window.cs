using System;

namespace Design_Patterns.DecoratorPattern.Day1
{
    public class Window : IComponent
    {
        public void Draw()
        {
            Console.WriteLine("Draw window");
        }

        public string GetDescription()
        {
            return "This is window description";
        }
    }
}
