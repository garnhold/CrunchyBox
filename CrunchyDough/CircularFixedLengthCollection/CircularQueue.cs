using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class CircularQueue<T> : CircularFixedLengthCollection<T>
    {
        public CircularQueue(int length) : base(length) { }
        public CircularQueue(IEnumerable<T> i) : base(i) { }

        public bool Advance(T to_add)
        {
            if (elements.Count < maximum_size)
                elements.Add(to_add);
            else
                elements.Advance(to_add);

            if (elements.Count == maximum_size)
                return true;

            return false;
        }
    }
}