namespace MitsubishiElectric.WidgetsRenderer.Core
{
    using System;
    using System.Collections.Generic;
    using MitsubishiElectric.WidgetsRenderer.Core.Widgets;

    public class Canvas : ICanvas
    {
        private IList<BaseWidget> _widgetsCollection;

        public Canvas()
        {
            this._widgetsCollection = new List<BaseWidget>();
        }

        public void Add(BaseWidget widget)
        {
            this._widgetsCollection.Add(widget);
        }

        public void PrintCanvas()
        {
            foreach (var widget in _widgetsCollection)
            {
                Console.WriteLine(widget.Draw());
            }
        }
    }
}