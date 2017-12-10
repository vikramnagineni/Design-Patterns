namespace Design_Patterns.DecoratorPattern.Day2
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

            // I need textbox with only horizontal scroll capability
            var horizontalScrollbarTextbox = new HorizontalScrollbarTextbox();
            horizontalScrollbarTextbox.DrawHorizontalScrollBar();

            // I need textbox with only vertical scroll capability
            var verticalScrollbarTexbox = new VerticalScrollbarTextbox();
            verticalScrollbarTexbox.DrawVerticalScrollbar();

            // I need textbox with only vertical and horizontal scroll capability
            var verticalHorizontalScrollbarTextbox = new VerticalHorizontalScrollbarTextbox();
            verticalHorizontalScrollbarTextbox.DrawHorizontalScrollBar();
            verticalHorizontalScrollbarTextbox.DrawVerticalScrollbar();
        }
    }
}
