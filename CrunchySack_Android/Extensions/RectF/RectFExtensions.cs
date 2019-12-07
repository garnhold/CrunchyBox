using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;
using Android.Content;
using Android.Graphics;
using Android.Content.Res;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Bun;
    using Sack;
    
    static public class RectFExtensions
    {
        static public bool TryCreateStrictMinMaxRectF(VectorF2 min, VectorF2 max, out RectF output)
        {
            bool result = true;

            float x = min.x;
            float y = min.y;

            float width = max.x - min.x;
            float height = max.y - min.y;

            if (width < 0.0f)
            {
                x = (min.x + max.x) * 0.5f;
                width = 0.0f;

                result = false;
            }

            if (height < 0.0f)
            {
                y = (min.y + max.y) * 0.5f;
                height = 0.0f;

                result = false;
            }

            output = new RectF(x, y, x + width, y + height);
            return result;
        }
        static public RectF CreateStrictMinMaxRectF(VectorF2 min, VectorF2 max)
        {
            RectF rect;

            TryCreateStrictMinMaxRectF(min, max, out rect);
            return rect;
        }

        static public RectF CreateMinMaxRectF(VectorF2 min, VectorF2 max)
        {
            min.Order(max, out min, out max);

            return CreateStrictMinMaxRectF(min, max);
        }

        static public RectF CreateCenterRectF(VectorF2 center, VectorF2 size)
        {
            VectorF2 extent = size * 0.5f;

            return CreateMinMaxRectF(center - extent, center + extent);
        }
        static public RectF CreateCenterRectF(VectorF2 center, float size)
        {
            return CreateCenterRectF(center, new VectorF2(size));
        }
    }
}