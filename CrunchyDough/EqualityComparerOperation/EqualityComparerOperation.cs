using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class EqualityComparerOperation<T> : IEqualityComparer<T>
    {
        private Operation<bool, T, T> equals;
        private Operation<int, T> get_hash_code;

        public EqualityComparerOperation(Operation<bool, T, T> e, Operation<int, T> g)
        {
            equals = e;
            get_hash_code = g;
        }

        public bool Equals(T x, T y)
        {
            return equals(x, y);
        }

        public int GetHashCode(T obj)
        {
            return get_hash_code(obj);
        }
    }
}