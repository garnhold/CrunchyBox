using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class Texture2DExtensions_Shrinkwrap
    {
        static public RectI2 ShrinkwrapSide(this Texture2D item, RectI2 rect, RectSide side)
        {
            RectI2 center;
            RectI2 edge;

            do
            {
                rect.SplitBySideOffset(1, side, out center, out edge);

                if (item.IsSolid(edge))
                    return rect;

                rect = center;
            }
            while (center.IsCollapsed() == false);

            return center;
        }

        static public RectI2 ShrinkwrapRect(this Texture2D item, RectI2 rect)
        {
            return typeof(RectSide).GetEnumValues<RectSide>()
                .Apply(rect, (r, s) => item.ShrinkwrapSide(r, s));
        }

        static public RectI2 Shrinkwrap(this Texture2D item)
        {
            return item.ShrinkwrapRect(item.GetRectI2());
        }
    }
}