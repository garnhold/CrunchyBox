using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ICollectionTransform<T> : ICollection<T>, IEnumerable<T>
    {
        private int count;

        private Operation<IEnumerator<T>> get_operation;

        public bool IsReadOnly { get { return true; } }
        public int Count { get { return count; } }

        public ICollectionTransform(int c, Operation<IEnumerator<T>> g)
        {
            count = c;

            get_operation = g;
        }

        public ICollectionTransform(int c, IEnumerable<T> e) : this(c, () => e.GetEnumerator()) { }

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
            return get_operation();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}