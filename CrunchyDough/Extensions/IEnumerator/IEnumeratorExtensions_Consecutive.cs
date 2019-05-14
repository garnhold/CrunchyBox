using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumeratorExtensions_Consecutive
    {
        static public bool MoveConsecutiveNextStrict<T>(this IEnumerator<T> item, out T value1, out T value2)
        {
            if (item.MoveNext())
            {
                value1 = item.Current;

                if (item.MoveNext())
                {
                    value2 = item.Current;
                    return true;
                }
            }

            value1 = default(T);
            value2 = default(T);
            return false;
        }

        static public bool MoveConsecutiveNextPermissive<T>(this IEnumerator<T> item, out T value1, out T value2)
        {
            if (item.MoveNext())
            {
                value1 = item.Current;

                if (item.MoveNext())
                    value2 = item.Current;
                else
                    value2 = default(T);

                return true;
            }

            value1 = default(T);
            value2 = default(T);
            return false;
        }
    }
}