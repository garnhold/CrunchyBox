using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Get
    {
        static public bool TryGet<T>(this IEnumerable<T> item, int index, out T output)
        {
            IList<T> list;
            int current_index = 0;

            if (item != null)
            {
                if (item.Convert<IList<T>>(out list))
                    return list.TryGet(index, out output);

                foreach (T sub_item in item)
                {
                    if (current_index == index)
                    {
                        output = sub_item;
                        return true;
                    }

                    current_index++;
                }
            }

            output = default(T);
            return false;
        }
        static public T Get<T>(this IEnumerable<T> item, int index)
        {
            T output;

            item.TryGet(index, out output);
            return output;
        }

        static public bool TryGetFirst<T>(this IEnumerable<T> item, out T output)
        {
            IList<T> list;

            if (item != null)
            {
                if (item.Convert<IList<T>>(out list))
                    return list.TryGetFirst(out output);

                using (IEnumerator<T> iter = item.GetEnumerator())
                {
                    if (iter.MoveNext())
                    {
                        output = iter.Current;
                        return true;
                    }
                }
            }

            output = default(T);
            return false;
        }
        static public T GetFirst<T>(this IEnumerable<T> item)
        {
            T output;

            item.TryGetFirst(out output);
            return output;
        }

        static public bool TryGetFirstNonNull<T>(this IEnumerable<T> item, out T output)
        {
            return item.SkipNull().TryGetFirst(out output);
        }
        static public T GetFirstNonNull<T>(this IEnumerable<T> item)
        {
            T output;

            item.TryGetFirstNonNull(out output);
            return output;
        }

        static public bool TryGetLast<T>(this IEnumerable<T> item, out T output)
        {
            IList<T> list;

            if (item != null)
            {
                if (item.Convert<IList<T>>(out list))
                    return list.TryGetLast(out output);

                using (IEnumerator<T> iter = item.GetEnumerator())
                {
                    if (iter.MoveNext())
                    {
                        output = iter.Current;
                        while(iter.MoveNext())
                            output = iter.Current;

                        return true;
                    }
                }
            }

            output = default(T);
            return false;
        }
        static public T GetLast<T>(this IEnumerable<T> item)
        {
            T output;

            item.TryGetLast(out output);
            return output;
        }

        static public bool TryGetOnly<T>(this IEnumerable<T> item, out T output)
        {
            IList<T> list;

            if (item != null)
            {
                if (item.Convert<IList<T>>(out list))
                    return list.TryGetOnly(out output);

                using (IEnumerator<T> iter = item.GetEnumerator())
                {
                    if (iter.MoveNext())
                    {
                        output = iter.Current;
                        if (iter.MoveNext() == false)
                            return true;
                    }
                }
            }

            output = default(T);
            return false;
        }
        static public T GetOnly<T>(this IEnumerable<T> item)
        {
            T output;

            item.TryGetOnly(out output);
            return output;
        }

        static public bool TryGetBefore<T>(this IEnumerable<T> item, T value, out T output)
        {
            return item.EndBefore(value).TryGetLast(out output);
        }
        static public T GetBefore<T>(this IEnumerable<T> item, T value)
        {
            T output;

            item.TryGetBefore(value, out output);
            return output;
        }

        static public bool TryGetAfter<T>(this IEnumerable<T> item, T value, out T output)
        {
            return item.StartAfter(value).TryGetFirst(out output);
        }
        static public T GetAfter<T>(this IEnumerable<T> item, T value)
        {
            T output;

            item.TryGetAfter(value, out output);
            return output;
        }
    }
}