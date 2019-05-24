using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class ICatalog<T> : IList<T>
    {
        private IList<T> list;

        public int Count { get { return list.Count; } }
        public T this[int index] { get { return list[index]; } }

        static public implicit operator ICatalog<T>(List<T> l) { return l.AsCatalog(); }

        T IList<T>.this[int index] { get { return list[index]; } set { throw new NotSupportedException("ICatalog's do not support setting elements."); } }
        void IList<T>.Insert(int index, T value) { throw new NotSupportedException("ICatalog's do not support inserting elements."); }
        void IList<T>.RemoveAt(int index) { throw new NotSupportedException("ICatalog's do not support removing elements."); }

        bool ICollection<T>.IsReadOnly { get { return true; } }
        void ICollection<T>.Add(T to_add) { throw new NotSupportedException("ICatalog's do not support adding elements."); }
        bool ICollection<T>.Remove(T to_remove) { throw new NotSupportedException("ICatalog's do not support removing elements."); }
        void ICollection<T>.Clear() { throw new NotSupportedException("ICatalog's do not support clearing."); }

        public ICatalog(IList<T> l)
        {
            list = l;
        }

        public bool Contains(T to_check)
        {
            return list.Contains(to_check);
        }

        public int IndexOf(T to_check)
        {
            return list.IndexOf(to_check);
        }

        public void CopyTo(T[] array, int index)
        {
            list.CopyTo(array, index);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}