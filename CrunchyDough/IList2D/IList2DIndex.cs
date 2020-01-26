using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public struct IList2DIndex
    {
        private int x;
        private int y;

        public IList2DIndex(int nx, int ny)
        {
            x = nx;
            y = ny;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }
    }
}