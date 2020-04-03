namespace MitsubishiElectric.WidgetsRenderer.Tests
{
    using MitsubishiElectric.WidgetsRenderer.Core.Widgets;
    using Xunit;

    public class SquareWidgetTests
    {
        [Fact]
        public void DrawMethod_Should_Render_Size_And_XY_Positions()
        {
            // Arrange
            var widget = new SquareWidget(10, 10);

            // Act
            var renderedWidget = widget.Draw();

            // Assert
            Assert.NotNull(widget);
            Assert.Equal("Square (10, 10) Size= 0", renderedWidget);
        }
    }
}