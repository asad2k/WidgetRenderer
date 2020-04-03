namespace MitsubishiElectric.WidgetsRenderer.Core.Widgets
{
    using System;

    public class RectangleWidget : BaseWidget
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public RectangleWidget(int x, int y) : base(x, y)
        {
            this.Name = "Rectangle";
        }

        public override string Draw()
        {
            return $"{ this.Name } ({this.X}, { this.Y }) Height={ this.Height} Width={this.Width} Size= { this.Size }";
        }
    }
}