using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class IRegister<T> : IList<T>
    {
        private IList<T> list;

        public int Count { get { return list.Count; } }
        public T this[int index] { get { return list[index]; } set { list[index] = value; } }

        static public implicit operator IRegister<T>(List<T> l) { return l.AsRegister(); }

        void IList<T>.Insert(int index, T value) { throw new NotSupportedException("IRegister's do not support inserting elements."); }
        void IList<T>.RemoveAt(int index) { throw new NotSupportedException("IRegister's do not support removing elements."); }

        bool ICollection<T>.IsReadOnly { get { return true; } }
        void ICollection<T>.Add(T to_add) { throw new NotSupportedException("IRegister's do not support adding elements."); }
        bool ICollection<T>.Remove(T to_remove) { throw new NotSupportedException("IRegister's do not support removing elements."); }
        void ICollection<T>.Clear() { throw new NotSupportedException("IRegister's do not support clearing."); }

        public IRegister(IList<T> l)
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