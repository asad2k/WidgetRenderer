namespace MitsubishiElectric.WidgetsRenderer.Tests
{
    using MitsubishiElectric.WidgetsRenderer.Core.Widgets;
    using Xunit;

    public class CircleWidgetTests
    {
        [Fact]
        public void DrawMethod_Should_Render_Size_And_XY_Positions()
        {
            // Arrange
            var widget = new CircleWidget(100, 100) { Size = 20 };

            // Act
            var renderedWidget = widget.Draw();

            // Assert
            Assert.NotNull(widget);
            Assert.Equal("Circle (100, 100) Size=20", renderedWidget);
        }
    }
}