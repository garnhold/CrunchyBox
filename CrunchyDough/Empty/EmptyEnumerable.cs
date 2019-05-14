using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
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