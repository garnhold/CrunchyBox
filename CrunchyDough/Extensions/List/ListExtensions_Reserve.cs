using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ListExtensions_Reserve
    {
        static public void ReserveTotal<T>(this List<T> item, int size)
        {
            if (item.Capacity < size)
                item.Capacity = size;
        }

        static public void ReserveAdditional<T>(this List<T> item, int size)
        {
            item.ReserveTotal(item.Count + size);
        }
    }
}