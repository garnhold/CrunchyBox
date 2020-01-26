using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public struct IList2DCell<T>
    {
        private IList2D<T> list;
        private IList2DIndex index;

        public IList2DCell(IList2D<T> l, IList2DIndex i)
        {
            list = l;
            index = i;
        }

        public IList2DCell(IList2D<T> l, int x, int y) : this(l, new IList2DIndex(x, y)) { }

        public IList2D<T> GetList()
        {
            return list;
        }

        public IList2DIndex GetIndex()
        {
            return index;
        }
    }
}