using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumeratorExtensions_Bridge
    {
        static public IEnumerator<T> Bridge<T>(this IEnumerator item)
        {
            T cast;

            if (item != null)
            {
                while(item.MoveNext())
                {
                    if (item.Current.Convert<T>(out cast))
                        yield return cast;
                }
            }
        }
    }
}