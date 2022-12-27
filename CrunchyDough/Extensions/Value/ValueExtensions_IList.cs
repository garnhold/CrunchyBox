using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ValueExtensions_IList
    {
        static public IList<T> WrapAsIList<T>(this T item)
        {
            IList<T> list = new List<T>(1);

            list.Add(item);
            return list;
        }
    }
}