using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ValueExtensions_Compare
    {
        static public bool Conforms<T>(this T item, ref T output)
        {
            if (output == null)
                output = item;

            if (output.EqualsEX(item))
                return true;

            return false;
        }

        static public bool IsNull<T>(this T item)
        {
            if (item.EqualsEX(null))
                return true;

            return false;
        }

        static public bool IsNotNull<T>(this T item)
        {
            if (item.IsNull() == false)
                return true;

            return false;
        }
    }
}