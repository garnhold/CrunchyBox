using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class EmptyEnumerator<T> : IEnumerator<T>
    {
        static public readonly EmptyEnumerator<T> INSTANCE = new EmptyEnumerator<T>();

        public T Current
        {
            get
            {
                return default(T);
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        private EmptyEnumerator()
        {
        }

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
        }

        public void Dispose()
        {
        }
    }
}