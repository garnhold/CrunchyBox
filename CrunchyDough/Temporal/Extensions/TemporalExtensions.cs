using System;
using System.Reflection;

namespace Crunchy.Dough
{
    static public class TemporalExtensions
    {
        static public T StartAndGet<T>(this T item) where T : Temporal
        {
            item.Start();

            return item;
        }
    }
}