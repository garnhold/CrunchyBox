using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract class SignalingContainer_Collection<T> : SignalingContainer<T>, ICollection<T>
    {
        public bool IsReadOnly { get{ return false; } }

        public abstract int Count { get; }

        public abstract void Clear();
        public abstract bool TryAdd(T item);
        public abstract bool Remove(T item);
        public abstract bool Contains(T item);

        public abstract void CopyTo(T[] array, int array_index);

        public SignalingContainer_Collection()
        {
        }

        public void Add(T item)
        {
            TryAdd(item);
        }
    }
}