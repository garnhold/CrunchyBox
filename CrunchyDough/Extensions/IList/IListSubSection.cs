using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class IListSubSection<T> : IList<T>, IEnumerable<T>
    {
        private int start;
        private int end;
        private IList<T> list;

        private int count;

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
                return count;
            }
        }

        public T this[int index]
        {
            get
            {
                return list[start + index];
            }

            set
            {
                list[start + index] = value;
            }
        }

        public IListSubSection(int s, int e, IList<T> l)
        {
            IListSubSection<T> sl;

            start = s.BindBetween(0, l.Count);
            end = e.BindBetween(start, l.Count);

            if (l.Convert<IListSubSection<T>>(out sl))
            {
                start += sl.start;
                end += sl.start;
                list = sl.list;
            }
            else
            {
                list = l;
            }

            count = end - start;
        }

        public void Clear()
        {
            throw new InvalidOperationException("IListSubSection is Read Only");
        }

        public bool Remove(T item)
        {
            throw new InvalidOperationException("IListSubSection is Read Only");
        }

        public void RemoveAt(int index)
        {
            throw new InvalidOperationException("IListSubSection is Read Only");
        }

        public void Add(T item)
        {
            throw new InvalidOperationException("IListSubSection is Read Only");
        }

        public void Insert(int index, T item)
        {
            throw new InvalidOperationException("IListSubSection is Read Only");
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
            for(int i = start; i < end; i++)
                yield return list[i];
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}