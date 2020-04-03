namespace MitsubishiElectric.WidgetsRenderer
{
    using System;
    using MitsubishiElectric.WidgetsRenderer.Core;
    using MitsubishiElectric.WidgetsRenderer.Core.Widgets;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var squareWidget = new SquareWidget(10, 10) { Size = 1600 };
            var circleWidget = new CircleWidget(100, 100) { Size = 20 };
            var ellipseWidget = new EllipseWidget(50, 50) { HorizontalDiameter = 30, VerticalDiameter = 30, Size = 6283 };
            var rectangleWidget = new RectangleWidget(70, 30) { Height = 4, Width = 8, Size = 32 };
            var textBoxWithBackgroundColourWidget = new TextBoxWidget(20, 90) { Height = 6, Width = 24, Size = 144, Text = "Sample text", BackgroundColour = "Blue" };
            var textBoxWithDefaultBackgroundColour = new TextBoxWidget(30, 150) { Height = 6, Width = 24, Size = 144, Text = "Sample text with default colour" };

            var canvas = new Canvas();
            canvas.Add(squareWidget);
            canvas.Add(circleWidget);
            canvas.Add(ellipseWidget);
            canvas.Add(rectangleWidget);
            canvas.Add(textBoxWithBackgroundColourWidget);
            canvas.Add(textBoxWithDefaultBackgroundColour);

            canvas.PrintCanvas();
            Console.ReadKey();
        }
    }
}