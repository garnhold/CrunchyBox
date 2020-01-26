using System;
using System.Drawing;

namespace Crunchy.Winsys
{
    using Dough;
    using Salt;
    using Noodle;
    using Sauce;
    
    static public class DrawingPointExtensions_Magnitude
    {
        static public double GetSquaredMagnitude(this Point item)
        {
            return item.X.GetSquared() + item.Y.GetSquared();
        }

        static public double GetMagnitude(this Point item)
        {
            return Math.Sqrt(item.GetSquaredMagnitude());
        }
    }
}