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
    static public class DrawingPointExtensions_Convert
    {
        static public System.Drawing.PointF GetDrawingPointF(this System.Drawing.Point item)
        {
            return new System.Drawing.PointF(item.X, item.Y);
        }

        static public System.Windows.Point GetWindowsPoint(this System.Drawing.Point item)
        {
            return new System.Windows.Point(item.X, item.Y);
        }
    }
}