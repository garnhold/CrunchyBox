using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class CircularStack<T> : CircularFixedLengthCollection<T>
    {
        public CircularStack(int length) : base(length) { }
        public CircularStack(IEnumerable<T> i) : base(i) { }

        public bool Advance(T to_add)
        {
            if (elements.Count < maximum_size)
                elements.Insert(0, to_add);
            else
                elements.Unadvance(to_add);

            if (elements.Count == maximum_size)
                return true;

            return false;
        }
    }
}