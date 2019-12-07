using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_SkipEvery
    {
        static public IEnumerable<T> SkipEvery<T>(this IEnumerable<T> item, int n)
        {
            int i = 0;

            foreach (T sub_item in item)
            {
                if (i >= n)
                    i = 0;
                else
                {
                    yield return sub_item;
                    i++;
                }
            }
        }

        static public IEnumerable<T> SkipToEvery<T>(this IEnumerable<T> item, int n)
        {
            int i = 0;

            foreach (T sub_item in item)
            {
                if (i >= n)
                {
                    i = 0;
                    yield return sub_item;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}