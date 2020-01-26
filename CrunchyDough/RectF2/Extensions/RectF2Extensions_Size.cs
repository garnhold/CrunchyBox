using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectF2Extensions_Size
    {
        static public float GetWidth(this RectF2 item)
        {
            return item.max.x - item.min.x;
        }

        static public float GetHeight(this RectF2 item)
        {
            return item.max.y - item.min.y;
        }

        static public VectorF2 GetSize(this RectF2 item)
        {
            return new VectorF2(item.GetWidth(), item.GetHeight());
        }
    }
}