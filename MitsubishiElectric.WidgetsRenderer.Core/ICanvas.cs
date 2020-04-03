using System;
using System.Collections.Generic;
using System.Text;
using MitsubishiElectric.WidgetsRenderer.Core.Widgets;

namespace MitsubishiElectric.WidgetsRenderer.Core
{
    public interface ICanvas
    {
        void Add(BaseWidget widget);
        void PrintCanvas();
    }
}
