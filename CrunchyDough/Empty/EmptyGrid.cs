using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class EmptyGrid<T> : IGrid<T>
    {
        static public readonly EmptyGrid<T> INSTANCE = new EmptyGrid<T>();

        public T this[int x, int y]
        {
            get { throw new IndexOutOfRangeException(); }
            set { throw new IndexOutOfRangeException(); }
        }

        private EmptyGrid()
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