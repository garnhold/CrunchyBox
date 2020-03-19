using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_CappedInterpolate
    {
        static public J GetCappedInterpolate<T, J>(this IList<T> item, double index, Operation<J, T, T, double> mix_operation, Operation<J, T> convert_operation)
        {
            int index_int;
            double index_component;

            index.GetComponents(out index_int, out index_component);

            if (index_component <= double.Epsilon)
                return convert_operation(item.GetCapped(index_int));

            return mix_operation(item.GetCapped(index_int), item.GetCapped(index_int + 1), index_component);
        }

        static public T GetCappedInterpolate<T>(this IList<T> item, double index, Operation<T, T, T, double> operation)
        {
            return item.GetCappedInterpolate(index, operation, z => z);
        }
    }
}