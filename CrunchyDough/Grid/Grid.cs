using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class Grid<T> : IGrid<T>
    {
        private int width;
        private int height;

        private List<T> list;

        public T this[int x, int y]
        {
            get { return list[y * width + x]; }
            set { list[y * width + x] = value; }
        }

        public Grid(int w, int h)
        {
            width = w;
            height = h;

            list = new List<T>();
            list.AddEmptys(width * height);
        }
        public Grid(VectorI2 i) : this(i.x, i.y) { }

        public Grid(int w, int h, IEnumerable<T> v)
        {
            width = w;
            height = h;

            list = v.ToList();
            list.EnsureSizeWithEmptys(width * height);
        }
        public Grid(VectorI2 i, IEnumerable<T> v) : this(i.x, i.y, v) { }

        public Grid(int w, int h, Operation<T, int, int> operation) : this(w, h)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                    this[x, y] = operation(x, y);
            }
        }
        public Grid(VectorI2 i, Operation<T, int, int> operation) : this(i.x, i.y, operation) { }

        public Grid(IGrid<T> g) : this(g.GetWidth(), g.GetHeight(), (x, y) => g[x, y]) { }

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