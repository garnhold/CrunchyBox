using System;

namespace Crunchy.Dough
{    
    static public class FloatExtensions_Approximate
    {
        static public bool IsApproximatelyEqual(this float item, float other, float tolerance)
        {
            if ((item - other).GetAbs() <= tolerance)
                return true;

            return false;
        }
        static public bool IsApproximatelyEqual(this float item, float other)
        {
            return item.IsApproximatelyEqual(other, 1e-6f);
        }
    }
}