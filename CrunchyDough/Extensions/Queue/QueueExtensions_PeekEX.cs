using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class QueueExtensions_PeekEX
    {
        static public T PeekEX<T>(this Queue<T> item)
        {
            if (item.IsNotEmpty())
                return item.Peek();

            return default(T);
        }
    }
}