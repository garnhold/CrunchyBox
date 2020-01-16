using System;

using Avalonia;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class PointExtensions_Magnitude
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