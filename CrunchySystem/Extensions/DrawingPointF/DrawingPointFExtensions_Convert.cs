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
    
    static public class DrawingPointFExtensions_Convert
    {
        static public System.Drawing.Point GetDrawingPoint(this System.Drawing.PointF item)
        {
            return new System.Drawing.Point((int)item.X, (int)item.Y);
        }

        static public System.Windows.Point GetWindowsPoint(this System.Drawing.PointF item)
        {
            return new System.Windows.Point(item.X, item.Y);
        }
    }
}