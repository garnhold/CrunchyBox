using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class EmptySparseGrid<T> : ISparseGrid<T>
    {
        static public readonly EmptySparseGrid<T> INSTANCE = new EmptySparseGrid<T>();

        public T this[int x, int y]
        {
            get { throw new IndexOutOfRangeException(); }
            set { throw new IndexOutOfRangeException(); }
        }

        private EmptySparseGrid()
        {
        }

        public bool HasIndex(int x, int y)
        {
            return false;
        }

        public int GetWidth()
        {
            return 0;
        }

        public int GetHeight()
        {
            return 0;
        }

        public IEnumerable<VectorI2> GetIndexs()
        {
            return Empty.IEnumerable<VectorI2>();
        }
    }
}