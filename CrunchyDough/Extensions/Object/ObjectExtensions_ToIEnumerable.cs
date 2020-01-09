using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ObjectExtensions_ToIEnumerable
    {
        static public IEnumerable ToEnumerable(this object item)
        {
            IEnumerable enumerable;

            if (item.Convert<IEnumerable>(out enumerable) == false)
                enumerable = item.WrapAsEnumerable();

            return enumerable;
        }

        static public IEnumerable<T> ToEnumerable<T>(this object item)
        {
            return item.ToEnumerable().Bridge<T>();
        }
    }
}