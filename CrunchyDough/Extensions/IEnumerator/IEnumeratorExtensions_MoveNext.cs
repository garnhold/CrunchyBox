using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumeratorExtensions_MoveNext
    {
        static public bool MoveNextRepeatedly<T>(this IEnumerator<T> item, int times)
        {
            for (int i = 0; i < times; i++)
            {
                if (item.MoveNext() == false)
                    return false;
            }

            return true;
        }
    }
}