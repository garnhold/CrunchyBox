using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class BlackholeList<T> : IList<T>
    {
        static public readonly BlackholeList<T> INSTANCE = new BlackholeList<T>();

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public int Count
        {
            get
            {
                return 0;
            }
        }

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

        private BlackholeList()
        {
        }

        public void Clear()
        {
        }

        public bool Remove(T item)
        {
            return false;
        }

        public void RemoveAt(int index)
        {
        }

        public void Add(T item)
        {
        }

        public void Insert(int index, T item)
        {
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