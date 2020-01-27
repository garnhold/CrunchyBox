using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
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

        static public T[,] ToArray2D<T>(this IEnumerable<T> item, int width, int height)
        {
            T[,] array = new T[width, height];

            item.ProcessWithIndex((i, s) => array[i % width, i / width] = s);
            return array;
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