namespace MitsubishiElectric.WidgetsRenderer.Core.Widgets
{
    public class SquareWidget : BaseWidget
    {
        public SquareWidget(int x, int y) : base(x, y)
        {
            this.Name = "Square";
        }

        public override string Draw()
        {
            return $"{ this.Name } ({this.X}, { this.Y }) Size= { this.Size }";
        }
    }
}