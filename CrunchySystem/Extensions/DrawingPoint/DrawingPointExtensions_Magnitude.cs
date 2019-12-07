using System;
using System.Drawing;

namespace Crunchy.System
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
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