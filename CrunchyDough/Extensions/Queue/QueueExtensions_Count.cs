using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class QueueExtensions_Count
    {
        static public bool IsNotEmpty<T>(this Queue<T> item)
        {
            if (item != null)
            {
                if (item.Count > 0)
                    return true;
            }

            return false;
        }

        static public bool IsEmpty<T>(this Queue<T> item)
        {
            if (item.IsNotEmpty() == false)
                return true;

            return false;
        }
    }
}