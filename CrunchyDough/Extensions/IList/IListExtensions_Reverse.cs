using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IListExtensions_Reverse
    {
        static public IListReverse<T> GetReverse<T>(this IList<T> item)
        {
            return new IListReverse<T>(item);
        }
    }
}