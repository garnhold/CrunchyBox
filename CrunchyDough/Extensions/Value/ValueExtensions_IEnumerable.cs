using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ValueExtensions_IEnumerable
    {
        static public IEnumerable<T> WrapAsEnumerable<T>(this T item)
        {
            yield return item;
        }

        static public IEnumerable<T> Repeat<T>(this T item, int times)
        {
            for (int i = 0; i < times; i++)
                yield return item;
        }
    }
}