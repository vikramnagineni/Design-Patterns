namespace Design_Patterns.DecoratorPattern.Day1
{
    public static class DecoratorApp
    {
        public static void Run()
        {
            // I need window with only horizontal scroll capability
            var horizontalScrollbarWindow = new HorizontalScrollbarWindow();
            horizontalScrollbarWindow.DrawHorizontalScrollBar();

            // I need window with only vertical scroll capability
            var verticalScrollbarWindow = new VerticalScrollbarWindow();
            verticalScrollbarWindow.DrawVerticalScrollbar();

            // I need window with only vertical and horizontal scroll capability
            var verticalHorizontalScrollbarWindow = new VerticalHorizontalScrollbarWindow();
            verticalHorizontalScrollbarWindow.DrawHorizontalScrollBar();
            verticalHorizontalScrollbarWindow.DrawVerticalScrollbar();
        }
    }
}
