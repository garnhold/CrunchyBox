using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Get
    {
        static public bool TryGet<T>(this IList<T> item, int index, out T output)
        {
            if (item.IsIndexValid(index))
            {
                output = item[index];
                return true;
            }

            output = default(T);
            return false;
        }
        static public T Get<T>(this IList<T> item, int index)
        {
            T value;

            item.TryGet(index, out value);
            return value;
        }

        static public T GetFromEnd<T>(this IList<T> item, int index)
        {
            return item.Get(item.GetFinalIndex() - index);
        }

        static public bool TryGetFirst<T>(this IList<T> item, out T output)
        {
            return item.TryGet(0, out output);
        }
        static public T GetFirst<T>(this IList<T> item)
        {
            T value;

            item.TryGetFirst(out value);
            return value;
        }

        static public bool TryGetLast<T>(this IList<T> item, out T output)
        {
            return item.TryGet(item.GetFinalIndex(), out output);
        }
        static public T GetLast<T>(this IList<T> item)
        {
            T value;

            item.TryGetLast(out value);
            return value;
        }

        static public bool TryGetOnly<T>(this IList<T> item, out T output)
        {
            if (item.HasOnlyOne())
            {
                output = item.GetFirst();
                return true;
            }

            output = default(T);
            return false;
        }
        static public T GetOnly<T>(this IList<T> item)
        {
            T value;

            item.TryGetOnly(out value);
            return value;
        }
    }
}