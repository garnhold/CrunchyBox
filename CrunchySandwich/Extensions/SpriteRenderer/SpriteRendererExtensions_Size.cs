using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class SpriteRendererExtensions_Size
    {
        static public void SetSize(this SpriteRenderer item, Vector2 size)
        {
            if (item.drawMode == SpriteDrawMode.Simple)
                item.SetPlanarScale(size.GetComponentDivide(item.GetNativeSize()));
            else
            {
                item.size = size;
                item.SetPlanarScale(1.0f);
            }
        }
        static public void SetWidth(this SpriteRenderer item, float width)
        {
            item.SetSize(item.GetSize().GetWithX(width));
        }
        static public void SetHeight(this SpriteRenderer item, float height)
        {
            item.SetSize(item.GetSize().GetWithY(height));
        }

        static public Vector2 GetNativeSize(this SpriteRenderer item)
        {
            Sprite sprite = item.sprite;

            if (sprite != null)
                return sprite.GetWorldSize();

            return Vector2.zero;
        }

        static public Vector2 GetSize(this SpriteRenderer item)
        {
            if (item.drawMode == SpriteDrawMode.Simple)
                return item.GetNativeSize().GetComponentMultiply(item.GetPlanarScale());

            return item.size.GetComponentMultiply(item.GetPlanarScale());
        }

        static public Vector2 GetExtents(this SpriteRenderer item)
        {
            return item.GetSize() * 0.5f;
        }
    }
}