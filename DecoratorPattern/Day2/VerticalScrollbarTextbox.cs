using System;

namespace Design_Patterns.DecoratorPattern.Day2
{
    // Add vertical scrollbar functionality to textbox..
    public class VerticalScrollbarTextbox : Textbox
    {
        public void DrawVerticalScrollbar()
        {
            Console.WriteLine("Draw vertical scrollbar");
        }
    }
}
