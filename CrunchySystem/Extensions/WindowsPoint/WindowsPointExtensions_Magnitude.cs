using System;
using System.Windows;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySauce;

namespace CrunchySystem
{
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