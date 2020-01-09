using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class SignalingContainer<T> : IEnumerable<T>
    {
        protected abstract bool CanAdd(T item);
        protected abstract bool CanRemove(T item);

        public abstract IEnumerator<T> GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}