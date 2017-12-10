namespace Design_Patterns.DecoratorPattern.Day3
{
    public static class DecoratorApp
    {
        public static void Run()
        {
            var horizontalScrollbarWindow = new HorizontalScrollBarDecorator(new Window());
            horizontalScrollbarWindow.Draw();

            var verticalScrollbarWindow = new VerticalScrollBarDecorator(new Window());
            verticalScrollbarWindow.Draw();

            var horizontalVerticalScrollbarWindow = new HorizontalScrollBarDecorator(new VerticalScrollBarDecorator(new Window()));
            horizontalVerticalScrollbarWindow.Draw();

            var horizontalScrollbarTextbox = new HorizontalScrollBarDecorator(new Textbox());
            horizontalScrollbarTextbox.Draw();

            var verticalScrollbarTextbox = new VerticalScrollBarDecorator(new Textbox());
            verticalScrollbarTextbox.Draw();

            var horizontalVerticalScrollbarTextbox = new HorizontalScrollBarDecorator(new VerticalScrollBarDecorator(new Textbox()));
            horizontalVerticalScrollbarTextbox.Draw();
        }
    }
}
