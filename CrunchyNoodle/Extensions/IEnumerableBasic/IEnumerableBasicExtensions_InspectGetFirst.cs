using System;
using System.Text;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class IEnumerableBasicExtensions_InspectGetFirst
    {
        static public object InspectGetFirst(this IEnumerable item)
        {
            if (item != null)
            {
                foreach (object sub_item in item)
                    return sub_item;
            }

            return null;
        }

        static public bool InspectTryGetFirst(this IEnumerable item, out object value)
        {
            if (item != null)
            {
                foreach (object sub_item in item)
                {
                    value = sub_item;
                    return true;
                }
            }

            value = null;
            return false;
        }
    }
}