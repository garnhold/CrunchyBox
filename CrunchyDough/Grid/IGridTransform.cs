using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class IGridTransform<T> : IGrid<T>
    {
        private int width;
        private int height;

        private Operation<T, int, int> get_operation;
        private Process<int, int, T> set_process;

        public T this[int x, int y]
        {
            get { return get_operation(x, y); }
            set { set_process(x, y, value); }
        }

        public IGridTransform(int w, int h, Operation<T, int, int> g, Process<int, int, T> s)
        {
            width = w;
            height = h;

            get_operation = g ?? ((x, y) => throw new InvalidOperationException(GetType() + " doesn't support reading."));
            set_process = s ?? ((x, y, v) => throw new InvalidOperationException(GetType() + " doesn't support writing."));
        }

        public IGridTransform(int w, int h, Operation<T, int, int> g) : this(w, h, g, null) { }
        public IGridTransform(int w, int h, Process<int, int, T> s) : this(w, h, null, s) { }

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