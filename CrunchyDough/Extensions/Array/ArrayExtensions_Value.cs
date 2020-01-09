using System;

namespace Crunchy.Dough
{
    static public class ArrayExtensions_Value
    {
        static public bool TryGet<T>(this T[] item, int index, out T output)
        {
            if(item.IsIndexValid(index))
            {
                output = item[index];
                return true;
            }

            output = default(T);
            return false;
        }

        static public T Get<T>(this T[] item, int index)
        {
            T output;

            item.TryGet(index, out output);
            return output;
        }

        static public bool Set<T>(this T[] item, int index, T value)
        {
            if(item.IsIndexValid(index))
            {
                item[index] = value;
                return true;
            }

            return false;
        }
    }
}