using System;

namespace Design_Patterns.DecoratorPattern.Day2
{
    // Add vertical scrollbar functionality to window..
    public class VerticalScrollbarWindow: Window
    {
        public void DrawVerticalScrollbar()
        {
            Console.WriteLine("Draw vertical scrollbar");
        }
    }
}
