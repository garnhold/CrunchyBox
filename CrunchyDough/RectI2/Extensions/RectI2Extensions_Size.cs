using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectI2Extensions_Size
    {
        static public int GetWidth(this RectI2 item)
        {
            return item.max.x - item.min.x;
        }

        static public int GetHeight(this RectI2 item)
        {
            return item.max.y - item.min.y;
        }

        static public VectorI2 GetSize(this RectI2 item)
        {
            return new VectorI2(item.GetWidth(), item.GetHeight());
        }
    }
}