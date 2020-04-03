namespace MitsubishiElectric.WidgetsRenderer.Core.Widgets
{
    public abstract class BaseWidget
    {
        public string Name { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public int Size { get; set; }

        public BaseWidget(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public abstract string Draw();
    }
}