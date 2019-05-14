using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StackExtensions_Count
    {
        static public bool IsNotEmpty<T>(this Stack<T> item)
        {
            if (item != null)
            {
                if (item.Count > 0)
                    return true;
            }

            return false;
        }

        static public bool IsEmpty<T>(this Stack<T> item)
        {
            if (item.IsNotEmpty() == false)
                return true;

            return false;
        }
    }
}