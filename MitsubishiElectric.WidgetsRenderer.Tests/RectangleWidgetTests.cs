using MitsubishiElectric.WidgetsRenderer.Core.Widgets;
using Xunit;

namespace MitsubishiElectric.WidgetsRenderer.Tests
{
    public class RectangleWidgetTests
    {
        [Fact]
        public void DrawMethod_Should_Render_Size_XY_Positions_Height_Width()
        {
            // Arrange
            var widget = new RectangleWidget(70, 30) { Height = 4, Width = 8, Size = 32 };

            // Act
            var renderedWidget = widget.Draw();

            // Assert
            Assert.NotNull(widget);
            Assert.Equal("Rectangle (70, 30) Height=4 Width=8 Size= 32", renderedWidget);
        }
    }
}