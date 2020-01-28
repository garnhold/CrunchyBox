using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_GetOrCreateValue
    {
        static public T GetOrCreateValue<T>(this IGrid<T> item, int x, int y, Operation<T, int, int> operation)
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
        static public T GetOrCreateValue<T>(this IGrid<T> item, int x, int y, Operation<T> operation)
        {
            return item.GetOrCreateValue<T>(x, y, (ix, iy) => operation());
        }

        static public T GetOrCreateDefaultValue<T>(this IGrid<T> item, int x, int y)
        {
            return item.GetOrCreateValue(x, y, () => typeof(T).CreateInstance<T>());
        }

        static public T GetOrCreateKeyedValue<T>(this IGrid<T> item, int x, int y)
        {
            return item.GetOrCreateValue(x, y, () => typeof(T).CreateInstance<T>(x, y));
        }
    }
}