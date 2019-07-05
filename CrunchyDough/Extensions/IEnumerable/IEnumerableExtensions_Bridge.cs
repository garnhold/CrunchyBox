using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Bridge
    {
        static public IEnumerable<OUTPUT_TYPE> Bridge<OUTPUT_TYPE>(this IEnumerable item)
        {
            if (item != null)
            {
                foreach (object sub_item in item)
                    yield return sub_item.Convert<OUTPUT_TYPE>();
            }
        }
    }
}