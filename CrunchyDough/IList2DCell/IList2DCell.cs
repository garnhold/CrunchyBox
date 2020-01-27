using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public struct IList2DCell<T>
    {
        private VectorI2 index;

        private IList2D<T> list;

        public IList2DCell(VectorI2 i, IList2D<T> l)
        {
            index = i;

            list = l;
        }

        public IList2DCell(int x, int y, IList2D<T> l) : this(new VectorI2(x, y), l) { }

        public VectorI2 GetIndex()
        {
            return index;
        }

        public IList2D<T> GetList()
        {
            return list;
        }
    }
}