using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class Enumerable
    {
        static public IEnumerable<T> New<T>()
        {
            return Empty.IEnumerable<T>();
        }

        static public IEnumerable<T> New<T>(params T[] items)
        {
            return items;
        }

        static public IEnumerable<T> New<T>(params IEnumerable<T>[] items)
        {
            return items.Flatten();
        }
    }
}