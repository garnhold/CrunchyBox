using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class List2D<T> : IList2D<T>
    {
        private int width;
        private int height;

        private List<T> list;

        public T this[int x, int y]
        {
            get { return list[y * width + x]; }
            set { list[y * width + x] = value; }
        }

        public List2D(int w, int h)
        {
            width = w;
            height = h;

            list = new List<T>();
            list.AddEmptys(width * height);
        }

        public List2D(IList2D<T> l) : this(l.GetWidth(), l.GetHeight())
        {
            l.ProcessWithIndexs((x, y, v) => this[x, y] = v);
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }
    }
}