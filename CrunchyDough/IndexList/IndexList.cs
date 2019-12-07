using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class IndexList : IList<int>
    {
        private int count;

        public bool IsReadOnly { get { return true; } }
        public int Count { get { return count; } }

        public int this[int index]
        {
            get { return index; }
            set { throw new InvalidOperationException("IndexList's do not support setting elements."); }
        }

        public IndexList(int c)
        {
            count = c;
        }

        public void Clear()
        {
            throw new InvalidOperationException("IndexList's do not support clearing.");
        }

        public bool Remove(int item)
        {
            throw new InvalidOperationException("IndexList's do not support removing elements.");
        }

        public void RemoveAt(int index)
        {
            throw new InvalidOperationException("IndexList's do not support removing elements.");
        }

        public void Add(int item)
        {
            throw new InvalidOperationException("IndexList's do not support adding elements.");
        }

        public void Insert(int index, int item)
        {
            throw new InvalidOperationException("IndexList's do not support inserting elements.");
        }

        public int IndexOf(int item)
        {
            if (this.IsIndexValid(item))
                return item;

            return -1;
        }

        public bool Contains(int item)
        {
            if (this.IsIndexValid(item))
                return true;

            return false;
        }

        public void CopyTo(int[] array, int array_index)
        {
            int start = array_index;
            int end = array.Length.Min(array_index + count);

            int value = 0;
            for (int i = start; i < end; i++)
                array[i] = value++;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
                yield return i;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}