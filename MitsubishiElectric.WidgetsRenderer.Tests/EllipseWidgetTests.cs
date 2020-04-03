namespace MitsubishiElectric.WidgetsRenderer.Tests
{
    using MitsubishiElectric.WidgetsRenderer.Core.Widgets;
    using Xunit;

    public class EllipseWidgetTests
    {
        [Fact]
        public void DrawMethod_Should_Render_Size_XY_Positions_Horizontal_Veritical_Diameters()
        {
            // Arrange
            var widget = new EllipseWidget(50, 50) { HorizontalDiameter = 30, VerticalDiameter = 30, Size = 6283 };

            // Act
            var renderedWidget = widget.Draw();

            // Assert
            Assert.NotNull(widget);
            Assert.Equal("Ellipse (50, 50) HorizontalDiameter=30 VerticalDiameter=30 Size=6283", renderedWidget);
        }
    }
}