using System;
using System.Drawing;

namespace Crunchy.Winsys
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Sauce;
    
    static public class DrawingPointFExtensions_Magnitude
    {
        static public double GetSquaredMagnitude(this PointF item)
        {
            return item.X.GetSquared() + item.Y.GetSquared();
        }

        static public double GetMagnitude(this PointF item)
        {
            return Math.Sqrt(item.GetSquaredMagnitude());
        }
    }
}