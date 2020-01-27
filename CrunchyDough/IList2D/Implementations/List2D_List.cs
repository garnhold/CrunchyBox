using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class List2D_List<T> : IList2D<T>
    {
        private int width;
        private int height;

        private List<T> list;

        public T this[int x, int y]
        {
            get { return list[y * width + x]; }
            set { list[y * width + x] = value; }
        }

        public List2D_List(int w, int h)
        {
            width = w;
            height = h;

            list = new List<T>();
            list.AddEmptys(width * height);
        }

        public List2D_List(int w, int h, IEnumerable<T> v)
        {
            width = w;
            height = h;

            list = v.ToList();
            list.EnsureSizeWithEmptys(width * height);
        }

        public List2D_List(int w, int h, Operation<T, int, int> operation) : this(w, h)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                    this[x, y] = operation(x, y);
            }
        }

        public List2D_List(IList2D<T> l) : this(l.GetWidth(), l.GetHeight(), (x, y) => l[x, y]) { }

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