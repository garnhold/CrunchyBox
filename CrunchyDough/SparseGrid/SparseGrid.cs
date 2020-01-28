using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class SparseGrid<T> : ISparseGrid<T>
    {
        private int width;
        private int height;

        private Dictionary<VectorI2, T> points;

        public T this[int x, int y]
        {
            get
            {
                if (this.IsIndexValid(x, y) == false)
                    throw new IndexOutOfRangeException();

                return points.GetValue(new VectorI2(x, y)); 
            }

            set
            {
                if (this.IsIndexValid(x, y) == false)
                    throw new IndexOutOfRangeException();

                points[new VectorI2(x, y)] = value;
            }
        }

        public SparseGrid()
        {
            points = new Dictionary<VectorI2, T>();
        }

        public bool HasIndex(int x, int y)
        {
            if (points.ContainsKey(new VectorI2(x, y)))
                return true;

            return false;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        public IEnumerable<VectorI2> GetIndexs()
        {
            return points.Keys;
        }
    }
}