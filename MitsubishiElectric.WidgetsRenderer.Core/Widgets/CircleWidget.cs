namespace MitsubishiElectric.WidgetsRenderer.Core.Widgets
{
    public class CircleWidget : BaseWidget
    {
        public CircleWidget(int x, int y) : base(x, y)
        {
            this.Name = "Circle";
        }

        public override string Draw()
        {
            return $"{ this.Name } ({this.X}, { this.Y }) Size={  this.Size }";
        }
    }
}