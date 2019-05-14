using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class Enumerable
    {
        static public IEnumerable<T> New<T>(params T[] items)
        {
            return items;
        }
    }
}