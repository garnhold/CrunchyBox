using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ObjectExtensions_Compare
    {
        static public bool EqualsEX(this Object item, Object obj)
        {
            if (item != null)
                return item.Equals(obj);

            if (obj != null)
                return obj.Equals(item);

            return true;
        }

        static public bool NotEqualsEX(this Object item, Object obj)
        {
            if (item.EqualsEX(obj) == false)
                return true;

            return false;
        }

        static public int GetHashCodeEX(this Object item)
        {
            if (item != null)
                return item.GetHashCode();

            return 0;
        }
    }
}