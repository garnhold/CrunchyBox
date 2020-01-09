using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Sequence
    {
        static public IEnumerable<List<T>> GetSequences<T>(this IEnumerable<T> item, int length)
        {
            CircularQueue<T> sequence = new CircularQueue<T>(length);

            foreach (T sub_item in item)
            {
                if (sequence.Advance(sub_item))
                    yield return new List<T>(sequence);
            }
        }
    }
}