using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumeratorExtensions_IEnumerable
    {
        static public IEnumerable<T> ToEnumerable<T>(this IEnumerator<T> enumerator)
        {
            using (enumerator)
            {
                while (enumerator.MoveNext())
                    yield return enumerator.Current;
            }
        }
    }
}