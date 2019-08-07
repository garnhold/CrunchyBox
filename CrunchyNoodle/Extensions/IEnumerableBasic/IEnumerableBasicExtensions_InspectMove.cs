using System;
using System.Text;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class IEnumerableBasicExtensions_InspectMove
    {
        static public bool InspectMove(this IEnumerable item, int src_index, int dst_index)
        {
            if (item != null)
            {
                object value = item.InspectGet(src_index);

                item.InspectRemoveAt(src_index);
                item.InspectInsert(dst_index, value);
                return true;
            }

            return false;
        }
    }
}