using System;

namespace Crunchy.Dough
{
    static public class ValueExtensions_Chain
    {
        static public T Chain<T>(this T item, Process<T> process)
        {
            process(item);

            return item;
        }

        static public T ChainIfNull<T>(this T item, Process<T> process)
        {
            if (item.IsNull())
                return item.Chain(process);

            return item;
        }

        static public T ChainIfNotNull<T>(this T item, Process<T> process)
        {
            if (item.IsNotNull())
                return item.Chain(process);

            return item;
        }
    }
}