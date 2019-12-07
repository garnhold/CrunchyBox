using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class CircularFixedLengthCollection<T> : IEnumerable<T>
    {
        protected int maximum_size;
        protected CircularList<T> elements;

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
                return elements[index];
            }

            set
            {
                elements[index] = value;
            }
        }

        public CircularFixedLengthCollection(int length)
        {
            maximum_size = length;
            elements = new CircularList<T>();
        }

        public CircularFixedLengthCollection(IEnumerable<T> i)
        {
            elements = new CircularList<T>(i);
            maximum_size = elements.Count;
        }

        public void Clear()
        {
            elements.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return elements.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}