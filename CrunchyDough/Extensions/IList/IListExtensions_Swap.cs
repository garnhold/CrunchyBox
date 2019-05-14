using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IListExtensions_Swap
    {
        static public void SwapValues<T>(this IList<T> item, int index1, int index2)
        {
            T temp = item[index1];

            item[index1] = item[index2];
            item[index2] = temp;
        }
    }
}