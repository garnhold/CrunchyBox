using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Bridge
    {
        static public IEnumerable<OUTPUT_TYPE> Bridge<OUTPUT_TYPE>(this IEnumerable item)
        {
            OUTPUT_TYPE cast;

            if (item != null)
            {
                foreach (object sub_item in item)
                {
                    if (sub_item.Convert<OUTPUT_TYPE>(out cast))
                        yield return cast;
                }
            }
        }
    }
}