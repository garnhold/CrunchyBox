using System;

namespace Crunchy.Dough
{
    static public class ValueExtensions_Assert
    {
        static public T AssertNotNull<T>(this T item, Operation<Exception> o)
        {
            if (item.IsNotNull())
                return item;

            throw o();
        }
        static public T AssertNotNull<T>(this T item, bool assert, Operation<Exception> o)
        {
            if (assert)
                return item.AssertNotNull(o);

            return item;
        }

        static public J AssertConvert<T, J>(this T item, Operation<Exception> o)
        {
            J cast;

            if (item.Convert<J>(out cast))
                return cast;

            throw o();
        }
        static public J AssertConvert<T, J>(this T item, bool assert, Operation<Exception> o)
        {
            if (assert)
                return item.AssertConvert<T, J>(o);

            return item.Convert<J>();
        }
    }
}