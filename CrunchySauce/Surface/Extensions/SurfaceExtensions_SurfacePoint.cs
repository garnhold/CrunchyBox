using System;

namespace CrunchySauce
{
    static public class SurfaceExtensions_SurfacePoint
    {
        static public bool IsValidPoint<T>(this Surface<T> item, SurfacePoint to_check)
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