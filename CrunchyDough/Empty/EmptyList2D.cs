using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class EmptyList2D<T> : IList2D<T>
    {
        static public readonly EmptyList2D<T> INSTANCE = new EmptyList2D<T>();

        public T this[int x, int y]
        {
            get { throw new IndexOutOfRangeException(); }
            set { throw new IndexOutOfRangeException(); }
        }

        private EmptyList2D()
        {
        }

        public int GetWidth()
        {
            return 0;
        }

        public int GetHeight()
        {
            return 0;
        }
    }
}