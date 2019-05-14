using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class IListReverse<T> : IList<T>, IEnumerable<T>
    {
        private IList<T> list;
        private int last_index;

        public bool IsReadOnly
        {
            get
            {
                return true;
            }
        }

        public int Count
        {
            get
            {
                return list.Count;
            }
        }

        public T this[int index]
        {
            get
            {
                return list[last_index - index];
            }

            set
            {
                list[last_index - index] = value;
            }
        }

        public IListReverse(IList<T> l)
        {
            list = l;
            last_index = l.GetFinalIndex();
        }

        public void Clear()
        {
            throw new InvalidOperationException("IListReverse is Read Only");
        }

        public bool Remove(T item)
        {
            throw new InvalidOperationException("IListReverse is Read Only");
        }

        public void RemoveAt(int index)
        {
            throw new InvalidOperationException("IListReverse is Read Only");
        }

        public void Add(T item)
        {
            throw new InvalidOperationException("IListReverse is Read Only");
        }

        public void Insert(int index, T item)
        {
            throw new InvalidOperationException("IListReverse is Read Only");
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
            for(int i = last_index; i >= 0 ; i--)
                yield return list[i];
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}