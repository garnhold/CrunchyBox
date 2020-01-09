using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_ICatalog
    {
        static public ICatalog<T> AsCatalog<T>(this IList<T> item)
        {
            return new ICatalog<T>(item);
        }
    }
}