using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class IList2DTransform<T> : IList2D<T>
    {
        private Operation<int> get_width;
        private Operation<int> get_height;

        private Operation<T, int, int> get_operation;
        private Process<int, int, T> set_process;

        public T this[int x, int y]
        {
            get { return get_operation(x, y); }
            set { set_process(x, y, value); }
        }

        public IList2DTransform(Operation<int> w, Operation<int> h, Operation<T, int, int> g, Process<int, int, T> s)
        {
            get_width = w;
            get_height = h;

            get_operation = g ?? ((x, y) => throw new InvalidOperationException(GetType() + " doesn't support reading."));
            set_process = s ?? ((x, y, v) => throw new InvalidOperationException(GetType() + " doesn't support writing."));
        }

        public IList2DTransform(Operation<int> w, Operation<int> h, Operation<T, int, int> g) : this(w, h, g, null) { }
        public IList2DTransform(Operation<int> w, Operation<int> h, Process<int, int, T> s) : this(w, h, null, s) { }

        public int GetWidth()
        {
            return get_width();
        }

        public int GetHeight()
        {
            return get_height();
        }
    }
}