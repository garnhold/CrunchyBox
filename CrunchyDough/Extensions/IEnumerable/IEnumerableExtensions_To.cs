using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_To
    {
        static public T[] ToArray<T>(this IEnumerable<T> item)
        {
            ICollection<T> collection;

            if (item == null)
                return Empty.Array<T>();

            if (item.Convert<ICollection<T>>(out collection))
                return collection.ToArray();

            return item.ToList().ToArray();
        }

        static public List<T> ToList<T>(this IEnumerable<T> item)
        {
            if (item == null)
                item = EmptyEnumerable<T>.INSTANCE;

            return new List<T>(item);
        }

        static public HashSet<T> ToHashSet<T>(this IEnumerable<T> item)
        {
            if (item == null)
                item = EmptyEnumerable<T>.INSTANCE;

            return new HashSet<T>(item);
        }

        static public Stack<T> ToStack<T>(this IEnumerable<T> item)
        {
            if (item == null)
                item = EmptyEnumerable<T>.INSTANCE;

            return new Stack<T>(item);
        }

        static public Queue<T> ToQueue<T>(this IEnumerable<T> item)
        {
            if (item == null)
                item = EmptyEnumerable<T>.INSTANCE;

            return new Queue<T>(item);
        }
    }
}