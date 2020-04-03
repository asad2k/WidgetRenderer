namespace MitsubishiElectric.WidgetsRenderer.Tests
{
    using MitsubishiElectric.WidgetsRenderer.Core;
    using MitsubishiElectric.WidgetsRenderer.Core.Widgets;
    using Moq;
    using Xunit;

    public class CanvasTests
    {
        [Fact]
        public void AddMethod_Should_Allow_NewWidget()
        {
            // Arrange
            var mockedCanvas = new Mock<ICanvas>();
            mockedCanvas.Setup(r => r.Add(It.IsAny<SquareWidget>()));
            var widget = new SquareWidget(10, 10) { Size = 1400 };
            var canvas = mockedCanvas.Object;

            // Act
            canvas.Add(widget);

            // Assert
            mockedCanvas.Verify(r => r.Add(widget), Times.AtLeastOnce);
        }

        [Fact]
        public void PrintCanvasMethod_Should_Print_Widgets()
        {
            // Arrange
            var mockedCanvas = new Mock<ICanvas>();
            mockedCanvas.Setup(r => r.PrintCanvas());
            var widget = new SquareWidget(10, 10) { Size = 1400 };
            var canvas = mockedCanvas.Object;

            // Act
            canvas.PrintCanvas();

            // Assert
            mockedCanvas.Verify(r => r.PrintCanvas(), Times.AtLeastOnce);
        }
    }
}