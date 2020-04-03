namespace MitsubishiElectric.WidgetsRenderer.Core.Widgets
{
    using System;

    public class EllipseWidget : BaseWidget
    {
        public int HorizontalDiameter { get; set; }
        public int VerticalDiameter { get; set; }

        public EllipseWidget(int x, int y) : base(x, y)
        {
            this.Name = "Ellipse";
        }

        public override string Draw()
        {
            return $"{ this.Name } ({this.X}, { this.Y }) HorizontalDiameter={this.HorizontalDiameter} VerticalDiameter={this.VerticalDiameter} Size={ this.Size }";
        }
    }
}