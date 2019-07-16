using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StackExtensions_PeekEX
    {
        static public T PeekEX<T>(this Stack<T> item)
        {
            if (item.IsNotEmpty())
                return item.Peek();

            return default(T);
        }
    }
}