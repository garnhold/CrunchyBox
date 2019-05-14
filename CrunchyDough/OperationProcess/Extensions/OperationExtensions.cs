using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class OperationExtensions
    {
        static public IEnumerable<T> ExecuteRepeated<T>(this Operation<T> item, int times)
        {
            for (int i = 0; i < times; i++)
                yield return item.Execute();
        }

        static public T Execute<T>(this Operation<T> item)
        {
            if (item != null)
                return item();

            return default(T);
        }

        static public T Execute<T, P1>(this Operation<T, P1> item, P1 p1)
        {
            if (item != null)
                return item(p1);

            return default(T);
        }

        static public T Execute<T, P1, P2>(this Operation<T, P1, P2> item, P1 p1, P2 p2)
        {
            if (item != null)
                return item(p1, p2);

            return default(T);
        }

        static public T Execute<T, P1, P2, P3>(this Operation<T, P1, P2, P3> item, P1 p1, P2 p2, P3 p3)
        {
            if (item != null)
                return item(p1, p2, p3);

            return default(T);
        }
    }
}