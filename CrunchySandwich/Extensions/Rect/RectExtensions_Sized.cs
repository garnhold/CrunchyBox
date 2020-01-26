using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class RectExtensions_Sized
    {
        static public Rect GetSizedAnchorMin(this Rect item, Vector2 size)
        {
            return RectExtensions.CreateMinMaxRect(
                item.min,
                item.min + size
            );
        }
        static public Rect GetWidthedAnchorLeft(this Rect item, float width)
        {
            return item.GetSizedAnchorMin(new Vector2(width, item.height));
        }
        static public Rect GetHeightedAnchorBottom(this Rect item, float height)
        {
            return item.GetSizedAnchorMin(new Vector2(item.width, height));
        }

        static public Rect GetSizedAnchorMax(this Rect item, Vector2 size)
        {
            return RectExtensions.CreateMinMaxRect(
                item.max - size,
                item.max
            );
        }
        static public Rect GetWidthedAnchorRight(this Rect item, float width)
        {
            return item.GetSizedAnchorMax(new Vector2(width, item.height));
        }
        static public Rect GetHeightedAnchorTop(this Rect item, float height)
        {
            return item.GetSizedAnchorMax(new Vector2(item.width, height));
        }

        static public Rect GetSizedAnchorCenter(this Rect item, Vector2 size)
        {
            return RectExtensions.CreateCenterRect(item.center, size);
        }
        static public Rect GetWidthedAnchorCenter(this Rect item, float width)
        {
            return item.GetSizedAnchorCenter(new Vector2(width, item.height));
        }
        static public Rect GetHeightedAnchorCenter(this Rect item, float height)
        {
            return item.GetSizedAnchorCenter(new Vector2(item.width, height));
        }
    }
}