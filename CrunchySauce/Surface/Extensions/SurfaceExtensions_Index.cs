using System;

namespace Crunchy.Sauce
{
    using Dough;

    static public class SurfaceExtensions_Index
    {
        static public bool IsValidPoint<T>(this Surface<T> item, VectorI2 to_check)
        {
            if (to_check.x >= 0 && to_check.x < item.GetWidth())
            {
                if (to_check.y >= 0 && to_check.y < item.GetHeight())
                    return true;
            }

            return false;
        }
    }
}