using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectF2Extensions
    {
        static public bool TryCreateStrictMinMaxRectF2(VectorF2 min, VectorF2 max, out RectF2 rect)
        {
            if (min.IsBoundBelow(max))
            {
                rect = new RectF2(min, max);
                return true;
            }

            rect = RectF2.ZERO;
            return false;
        }
        static public bool TryCreateStrictMinMaxRectF2(float left, float bottom, float right, float top, out RectF2 rect)
        {
            return TryCreateStrictMinMaxRectF2(new VectorF2(left, bottom), new VectorF2(right, top), out rect);
        }
        static public RectF2 CreateStrictMinMaxRectF2(VectorF2 min, VectorF2 max)
        {
            RectF2 rect;

            TryCreateStrictMinMaxRectF2(min, max, out rect);
            return rect;
        }
        static public RectF2 CreateStrictMinMaxRectF2(float left, float bottom, float right, float top)
        {
            return CreateStrictMinMaxRectF2(new VectorF2(left, bottom), new VectorF2(right, top));
        }

        static public RectF2 CreateLowerLeftRectF2(VectorF2 position, VectorF2 size)
        {
            return new RectF2(position, position + size);
        }
        static public RectF2 CreateLowerLeftRectF2(float x, float y, float width, float height)
        {
            return CreateLowerLeftRectF2(new VectorF2(x, y), new VectorF2(width, height));
        }

        static public RectF2 CreateCenterRectF2(VectorF2 position, VectorF2 size)
        {
            VectorF2 extents = size * 0.5f;

            return new RectF2(position - extents, position + extents);
        }

        static public RectF2 CreatePoints(IEnumerable<VectorF2> points)
        {
            return new RectF2(points.Min(), points.Max());
        }
    }
}