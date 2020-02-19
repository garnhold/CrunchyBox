using System;

namespace Crunchy.Dough
{
    static public class ValueExtensions_Assert
    {
        static public T AssertNotNull<T>(this T item, Operation<Exception> o)
        {
            if (item.IsNull())
                throw o();

            return item;
        }

        static public T AssertNotNull<T>(this T item, bool assert, Operation<Exception> o)
        {
            if (assert)
                return item.AssertNotNull(o);

            return item;
        }
    }
}