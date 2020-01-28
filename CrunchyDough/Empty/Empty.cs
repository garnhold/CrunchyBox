using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class Empty
    {
        static public T[] Array<T>()
        {
            return EmptyArray<T>.INSTANCE;
        }

        static public IList<T> IList<T>()
        {
            return EmptyList<T>.INSTANCE;
        }

        static public IGrid<T> IGrid<T>()
        {
            return EmptyGrid<T>.INSTANCE;
        }

        static public ISparseGrid<T> ISparseGrid<T>()
        {
            return EmptySparseGrid<T>.INSTANCE;
        }

        static public ICollection<T> ICollection<T>()
        {
            return EmptyList<T>.INSTANCE;
        }

        static public IEnumerable<T> IEnumerable<T>()
        {
            return EmptyEnumerable<T>.INSTANCE;
        }

        static public IDictionary<KEY_TYPE, VALUE_TYPE> IDictionary<KEY_TYPE, VALUE_TYPE>()
        {
            return EmptyDictionary<KEY_TYPE, VALUE_TYPE>.INSTANCE;
        }
    }
}