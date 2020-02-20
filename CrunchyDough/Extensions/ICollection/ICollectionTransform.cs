using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ICollectionTransform<T> : ICollection<T>, IEnumerable<T>
    {
        private int count;
        private IEnumerable<T> enumerable;

        public bool IsReadOnly { get { return true; } }
        public int Count { get { return count; } }

        public ICollectionTransform(int c, IEnumerable<T> e)
        {
            count = c;
            enumerable = e;
        }

        public void Clear()
        {
            throw new InvalidOperationException(GetType() + " is Read Only");
        }

        public bool Remove(T item)
        {
            throw new InvalidOperationException(GetType() + " is Read Only");
        }

        public void Add(T item)
        {
            throw new InvalidOperationException(GetType() + " is Read Only");
        }

        public bool Contains(T item)
        {
            return this.Has(item);
        }

        public void CopyTo(T[] array, int array_index)
        {
            foreach (T item in this)
                array[array_index++] = item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return enumerable.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}