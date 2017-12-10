using System;

namespace Design_Patterns.DecoratorPattern.Day2
{
    // Add horizontal scrollbar functionality to textbox..

    // These are the issues with following code
    // 1. Eventhough adding horizontal scrollbar is same for both window and textbox, the code is not reused and it is duplicated for both window and textbox.
    public class HorizontalScrollbarTextbox : Textbox
    {
        public void DrawHorizontalScrollBar()
        {
            Console.WriteLine("Draw horizontal scrollbar");
        }
    }
}
