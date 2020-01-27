using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_GetOrCreate
    {
        static public T GetOrCreate<T>(this IGrid<T> item, int x, int y, Operation<T, int, int> operation)
        {
            T value;

            if (item.TryGet<T>(x, y, out value))
            {
                if (value.IsNull())
                {
                    value = operation(x, y);
                    item[x, y] = value;
                }

                return value;
            }

            return default(T);
        }
        static public T GetOrCreate<T>(this IGrid<T> item, int x, int y, Operation<T> operation)
        {
            return item.GetOrCreate<T>(x, y, (ix, iy) => operation());
        }
    }
}