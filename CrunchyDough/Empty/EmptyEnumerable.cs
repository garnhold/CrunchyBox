using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class EmptyEnumerable<T> : IEnumerable<T>
    {
        static public readonly EmptyEnumerable<T> INSTANCE = new EmptyEnumerable<T>();

        private EmptyEnumerable()
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            return EmptyEnumerator<T>.INSTANCE;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}