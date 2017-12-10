using System;

namespace Design_Patterns.DecoratorPattern.Day2
{
    // Already we have created classes for horizontal and vertical scrollbar windows. Now if I need a window which has both horizontal and vertical scrollbars, i have to create new class

    // These are the issues with following code.
    // 1. We are duplicating the code which is already present in other classes.
    public class VerticalHorizontalScrollbarTextbox
    {
        public void DrawHorizontalScrollBar()
        {
            Console.WriteLine("Draw horizontal scrollbar");
        }

        public void DrawVerticalScrollbar()
        {
            Console.WriteLine("Draw vertical scrollbar");
        }
    }
}
