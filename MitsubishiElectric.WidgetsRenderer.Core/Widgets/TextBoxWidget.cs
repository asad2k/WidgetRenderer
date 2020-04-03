namespace MitsubishiElectric.WidgetsRenderer.Core.Widgets
{
    using System;

    public class TextBoxWidget : RectangleWidget
    {
        private const string DefaultBackgroundColour = "Red";
        private string _backgroundColour;

        public string BackgroundColour
        {
            get => string.IsNullOrEmpty(_backgroundColour) ? DefaultBackgroundColour : _backgroundColour;
            set => _backgroundColour = value;
        }

        public string Text { get; set; }

        public TextBoxWidget(int x, int y) : base(x, y)
        {
            this.Name = "TextBox";
        }

        public override string Draw()
        {
            return $"{ this.Name } ({this.X}, { this.Y }) Height= {this.Height} Width={this.Width} Size={ this.Size } BackgroundColour={ this.BackgroundColour } TextContent = { this.Text }";
        }
    }
}