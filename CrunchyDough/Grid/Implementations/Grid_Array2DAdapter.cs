using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class Grid_Array2DAdapter<T> : IGrid<T>
    {
        private T[,] array;

        public T this[int x, int y]
        {
            get { return array[x, y]; }
            set { array[x, y] = value; }
        }

        public Grid_Array2DAdapter(T[,] a)
        {
            array = a;
        }

        public int GetWidth()
        {
            return array.GetWidth();
        }

        public int GetHeight()
        {
            return array.GetHeight();
        }
    }
}