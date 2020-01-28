using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectI2Extensions_Points
    {
        static public VectorI2 GetLowerLeftPoint(this RectI2 item)
        {
            return item.min;
        }

        static public VectorI2 GetUpperRightPoint(this RectI2 item)
        {
            return item.max;
        }

        static public VectorI2 GetLowerRightPoint(this RectI2 item)
        {
            return new VectorI2(item.GetRight(), item.GetBottom());
        }

        static public VectorI2 GetUpperLeftPoint(this RectI2 item)
        {
            return new VectorI2(item.GetLeft(), item.GetTop());
        }

        static public VectorF2 GetCenterPoint(this RectI2 item)
        {
            return new VectorF2(item.GetHorizontalCenter(), item.GetVerticalCenter());
        }

        static public IEnumerable<VectorI2> GetPoints(this RectI2 item)
        {
            for (int y = item.GetBottom(); y < item.GetTop(); y++)
            {
                for (int x = item.GetLeft(); x < item.GetRight(); x++)
                    yield return new VectorI2(x, y);
            }
        }
    }
}