using System;
using System.Drawing;
using System.Windows;

namespace Crunchy.System
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Sauce;
    
    static public class WindowsPointExtensions_Convert
    {
        static public System.Drawing.PointF GetDrawingPointF(this System.Windows.Point item)
        {
            return new System.Drawing.PointF((float)item.X, (float)item.Y);
        }

        static public System.Drawing.Point GetDrawingPoint(this System.Windows.Point item)
        {
            return new System.Drawing.Point((int)item.X, (int)item.Y);
        }
    }
}