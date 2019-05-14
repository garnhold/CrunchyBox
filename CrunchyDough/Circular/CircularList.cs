using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class CircularList<T> : IList<T>, IEnumerable<T>
    {
        private int first_index;
        private List<T> elements;

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
                return elements.Count;
            }
        }

        public T this[int index]
        {
            get
            {
                return elements.GetLooped(index + first_index);
            }

            set
            {
                elements.SetLooped(index + first_index, value);
            }
        }

        private void SetFirstIndex(int index)
        {
            first_index = elements.GetLoopedIndex(index);
        }

        private void AdjustFirstIndex(int amount)
        {
            SetFirstIndex(first_index + amount);
        }

        private void MoveFirstIndexLeft()
        {
            AdjustFirstIndex(-1);
        }

        private void MoveFirstIndexRight()
        {
            AdjustFirstIndex(1);
        }

        public CircularList()
        {
            first_index = 0;
            elements = new List<T>();
        }

        public CircularList(IEnumerable<T> i)
        {
            first_index = 0;
            elements = new List<T>(i);
        }

        public void Clear()
        {
            elements.Clear();
        }

        public void Add(T item)
        {
            Insert(0, item);
            MoveFirstIndexRight();
        }

        public bool Remove(T item)
        {
            int index;

            if (this.TryFindIndexOf(out index, item))
            {
                RemoveAt(index);
                return true;
            }

            return false;
        }

        public void Insert(int index, T item)
        {
            if (elements.Count > 0)
            {
                int internal_index = elements.GetLoopedIndex(index + first_index);

                elements.Insert(internal_index, item);
                if (internal_index < first_index)
                    MoveFirstIndexRight();
            }
            else
            {
                elements.Add(item);
            }
        }

        public void RemoveAt(int index)
        {
            if (elements.Count > 0)
            {
                int internal_index = elements.GetLoopedIndex(index + first_index);

                elements.RemoveAt(internal_index);
                if (internal_index < first_index)
                    MoveFirstIndexLeft();
            }
        }

        public void Advance(T to_add)
        {
            MoveFirstIndexRight();
            this[-1] = to_add;
        }

        public void Unadvance(T to_add)
        {
            MoveFirstIndexLeft();
            this[0] = to_add;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            foreach (T item in this)
                array[arrayIndex++] = item;
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

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = first_index; i < elements.Count; i++)
                yield return elements[i];

            for (int i = 0; i < first_index; i++)
                yield return elements[i];
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}