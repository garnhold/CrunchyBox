using System;

namespace Crunchy.Sauce
{
    using Dough;
    
    static public class SurfaceSelectionExtensions_Add
    {
        static public bool Add<T>(this SurfaceSelection<T> item, VectorF2 point)
        {
            return item.Add(point.GetVectorI2());
        }

        static public void AddRectangle<T>(this SurfaceSelection<T> item, VectorF2 point1, VectorF2 point2)
        {
            VectorF2 lower;
            VectorF2 upper;

            point1.Order(point2, out lower, out upper);
            lower = lower.BindBetween(VectorF2.ZERO, item.GetDimensions());
            upper = upper.BindBetween(VectorF2.ZERO, item.GetDimensions());

            for (float y = lower.y; y <= upper.y; y++)
            {
                for (float x = lower.x; x <= upper.x; x++)
                    item.Add(new VectorF2(x, y));
            }
        }
    }
}