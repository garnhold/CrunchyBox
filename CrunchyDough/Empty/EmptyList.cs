using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class EmptyList<T> : IList<T>
    {
        static public readonly EmptyList<T> INSTANCE = new EmptyList<T>();

        public bool IsReadOnly { get { return true; } }
        public int Count { get { return 0; } }

        public T this[int index]
        {
            get
            {
                throw new IndexOutOfRangeException();
            }

            set
            {
                throw new IndexOutOfRangeException();
            }
        }

        private EmptyList()
        {
        }

        public void Clear()
        {
            throw new InvalidOperationException("EmptyList is Read Only");
        }

        public bool Remove(T item)
        {
            throw new InvalidOperationException("EmptyList is Read Only");
        }

        public void RemoveAt(int index)
        {
            throw new InvalidOperationException("EmptyList is Read Only");
        }

        public void Add(T item)
        {
            throw new InvalidOperationException("EmptyList is Read Only");
        }

        public void Insert(int index, T item)
        {
            throw new InvalidOperationException("EmptyList is Read Only");
        }

        public int IndexOf(T item)
        {
            return -1;
        }

        public bool Contains(T item)
        {
            return false;
        }

        public void CopyTo(T[] array, int array_index)
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