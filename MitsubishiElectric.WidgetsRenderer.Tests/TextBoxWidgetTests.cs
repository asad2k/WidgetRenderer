namespace MitsubishiElectric.WidgetsRenderer.Tests
{
    using MitsubishiElectric.WidgetsRenderer.Core.Widgets;
    using Xunit;

    public class TextBoxWidgetTests
    {
        [Fact]
        public void DrawMethod_Should_Render_Size_XY_Positions_Height_Width_Custom_BackgroundColour_TextContent()
        {
            // Arrange
            var widget = new TextBoxWidget(20, 90) { Height = 6, Width = 24, Size = 144, Text = "Sample text", BackgroundColour = "Blue" };

            // Act
            var renderedWidget = widget.Draw();

            // Assert
            Assert.NotNull(widget);
            Assert.Equal("TextBox (20, 90) Height= 6 Width=24 Size=144 BackgroundColour=Blue TextContent = Sample text", renderedWidget);
            Assert.DoesNotContain("Red", renderedWidget);
        }

        [Fact]
        public void DrawMethod_Should_Render_Size_XY_Positions_Height_Width_Default_BackgroundColour_TextContent()
        {
            // Arrange
            var widget = new TextBoxWidget(30, 150) { Height = 6, Width = 24, Size = 144, Text = "Sample text with default colour" };

            // Act
            var renderedWidget = widget.Draw();

            // Assert
            Assert.NotNull(widget);
            Assert.Equal("TextBox (30, 150) Height= 6 Width=24 Size=144 BackgroundColour=Red TextContent = Sample text with default colour", renderedWidget);
            Assert.Contains("Red", renderedWidget);
        }
    }
}