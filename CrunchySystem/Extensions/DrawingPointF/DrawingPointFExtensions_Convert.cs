using System;
using System.Drawing;
using System.Windows;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySauce;

namespace CrunchySystem
{
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