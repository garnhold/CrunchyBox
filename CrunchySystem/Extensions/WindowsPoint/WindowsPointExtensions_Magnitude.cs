using System;
using System.Windows;

namespace Crunchy.System
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Sauce;
    
    static public class WindowsPointExtensions_Magnitude
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