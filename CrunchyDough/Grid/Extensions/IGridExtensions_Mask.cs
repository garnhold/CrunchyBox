using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_Mask
    {
        static public IGrid<T> ConvertMaskedInclusion<T>(this IGrid<T> item, HashSet<VectorI2> included)
        {
            if (item != null)
            {
                return new IGridTransform<T>(item.GetWidth(), item.GetHeight(),
                    (x, y) => included.Contains(new VectorI2(x, y)).ConvertBool(() => item[x, y]),
                    (x, y, v) => included.Contains(new VectorI2(x, y)).IfTrue(() => item[x, y] = v)
                );
            }

            return Empty.IGrid<T>();
        }

        static public IGrid<T> ConvertMaskedExclusion<T>(this IGrid<T> item, HashSet<VectorI2> excluded)
        {
            if (item != null)
            {
                return new IGridTransform<T>(item.GetWidth(), item.GetHeight(),
                    (x, y) => excluded.Contains(new VectorI2(x, y)).GetFlipped().ConvertBool(() => item[x, y]),
                    (x, y, v) => excluded.Contains(new VectorI2(x, y)).GetFlipped().IfTrue(() => item[x, y] = v)
                );
            }

            return Empty.IGrid<T>();
        }
    }
}