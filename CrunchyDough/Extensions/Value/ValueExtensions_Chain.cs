using System;

namespace CrunchyDough
{
    static public class ValueExtensions_Chain
    {
        static public T Chain<T>(this T item, Process<T> process)
        {
            process(item);

            return item;
        }
    }
}