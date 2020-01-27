using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class IListTransform<T> : IList<T>, IEnumerable<T>
    {
        private int count;

        private Operation<T, int> get_operation;
        private Process<int, T> set_process;

        public bool IsReadOnly { get { return true; } }
        public int Count { get { return count; } }

        public T this[int index]
        {
            get { return get_operation(index); }
            set { set_process(index, value); }
        }

        public IListTransform(int c, Operation<T, int> g, Process<int, T> s)
        {
            count = c;

            get_operation = g ?? (i => throw new InvalidOperationException(GetType() + " doesn't support reading."));
            set_process = s ?? ((i, v) => throw new InvalidOperationException(GetType() + " doesn't support writing."));
        }

        public IListTransform(int c, Operation<T, int> g) : this(c, g, null) { }
        public IListTransform(int c, Process<int, T> s) : this(c, null, s) { }

        public void Clear()
        {
            throw new InvalidOperationException(GetType() + " is Read Only");
        }

        public bool Remove(T item)
        {
            throw new InvalidOperationException(GetType() + " is Read Only");
        }

        public void RemoveAt(int index)
        {
            throw new InvalidOperationException(GetType() + " is Read Only");
        }

        public void Add(T item)
        {
            throw new InvalidOperationException(GetType() + " is Read Only");
        }

        public void Insert(int index, T item)
        {
            throw new InvalidOperationException(GetType() + " is Read Only");
        }

        public int IndexOf(T item)
        {
            int index;

            if (this.TryFindIndexOf(out index, item))
                return index;

            return -1;
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
            for (int i = 0; i < count; i++)
                yield return this[i];
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}