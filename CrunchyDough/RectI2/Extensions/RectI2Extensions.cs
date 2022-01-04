using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectI2Extensions
    {
        static public bool TryCreateStrictMinMaxRectI2(VectorI2 min, VectorI2 max, out RectI2 rect)
        {
            if (min.IsBoundBelow(max))
            {
                rect = new RectI2(min, max);
                return true;
            }

            rect = RectI2.ZERO;
            return false;
        }
        static public bool TryCreateStrictMinMaxRectI2(int left, int bottom, int right, int top, out RectI2 rect)
        {
            return TryCreateStrictMinMaxRectI2(new VectorI2(left, bottom), new VectorI2(right, top), out rect);
        }
        static public RectI2 CreateStrictMinMaxRectI2(VectorI2 min, VectorI2 max)
        {
            RectI2 rect;

            TryCreateStrictMinMaxRectI2(min, max, out rect);
            return rect;
        }
        static public RectI2 CreateStrictMinMaxRectI2(int left, int bottom, int right, int top)
        {
            return CreateStrictMinMaxRectI2(new VectorI2(left, bottom), new VectorI2(right, top));
        }

        static public RectI2 CreateLowerLeftRectI2(VectorI2 position, VectorI2 size)
        {
            return new RectI2(position, position + size);
        }
        static public RectI2 CreateLowerLeftRectI2(int x, int y, int width, int height)
        {
            return CreateLowerLeftRectI2(new VectorI2(x, y), new VectorI2(width, height));
        }

        static public RectI2 CreateCenterRectI2(VectorI2 position, VectorI2 size)
        {
            VectorI2 extents = size / 2;

            return new RectI2(position - extents, position + extents);
        }

        static public RectI2 CreatePoints(IEnumerable<VectorI2> points)
        {
            return new RectI2(points.Min(), points.Max());
        }
    }
}