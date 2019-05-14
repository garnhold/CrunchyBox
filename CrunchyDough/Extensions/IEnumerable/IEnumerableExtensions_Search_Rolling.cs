using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Search_Rolling
    {
        static public T FindRolling<T>(this IEnumerable<T> item, Operation<T, T, T> operation)
        {
            T rolling = default(T);

            item.Process(i => rolling = i, i => rolling = operation.Execute(rolling, i));
            return rolling;
        }

        static public T FindRolling<T>(this IEnumerable<T> item, IEnumerable<RollingCriteria<T>> criteria)
        {
            return item.FindRolling(delegate(T i1, T i2) {
                T output;

                foreach (RollingCriteria<T> sub_criteria in criteria)
                {
                    if (sub_criteria.TrySelect(i1, i2, out output))
                        return output;
                }

                return i2;
            });
        }
        static public T FindRolling<T>(this IEnumerable<T> item, params RollingCriteria<T>[] criteria)
        {
            return item.FindRolling((IEnumerable<RollingCriteria<T>>)criteria);
        }
    }
}