using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Count
    {
        static public bool IsNotEmpty<T>(this IEnumerable<T> item)
        {
            if (item != null)
            {
                ICollection<T> collection;

                if (item.Convert<ICollection<T>>(out collection))
                    return collection.IsNotEmpty();

                using (IEnumerator<T> enumerator = item.GetEnumerator())
                {
                    if (enumerator.MoveNext())
                        return true;
                }
            }

            return false;
        }

        static public bool IsEmpty<T>(this IEnumerable<T> item)
        {
            if (item.IsNotEmpty() == false)
                return true;

            return false;
        }

        static public int Count<T>(this IEnumerable<T> item)
        {
            int count = 0;
            ICollection<T> collection;

            if (item != null)
            {
                if (item.Convert<ICollection<T>>(out collection))
                    count = collection.Count;
                else
                {
                    foreach (T sub_item in item)
                        count++;
                }
            }

            return count;
        }

        static public int Count<T>(this IEnumerable<T> item, Predicate<T> predicate, out int total)
        {
            int count = 0;

            total = 0;
            if (item != null)
            {
                foreach (T sub_item in item)
                {
                    if (predicate.DoesDescribe(sub_item))
                        count++;

                    total++;
                }
            }

            return count;
        }
        static public int Count<T>(this IEnumerable<T> item, Predicate<T> predicate)
        {
            int total;

            return item.Count(predicate, out total);
        }
        static public int Count<T>(this IEnumerable<T> item, T to_count)
        {
            return item.Count(i => i.EqualsEX(to_count));
        }
    }
}