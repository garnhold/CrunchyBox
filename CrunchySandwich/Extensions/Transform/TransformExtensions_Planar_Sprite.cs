using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class TransformExtensions_Planar_Sprite
    {
        static public void SetPlanarSpriteAsLine(this Transform item, Vector2 point1, Vector2 point2, float total_margin = 0.0f)
        {
            Vector2 diff = point2 - point1;

            item.SetPlanarPosition(point1.GetMidpoint(point2));
            item.SetPlanarRotation(diff.GetAngleInDegrees());
            item.SetPlanarSpriteWidth((diff.GetMagnitude() - total_margin).BindAbove(0.0f));
        }

        static public void SetPlanarSpriteSize(this Transform item, Vector2 size)
        {
            item.GetComponent<SpriteRenderer>().SetSize(size);
        }
        static public void SetPlanarSpriteWidth(this Transform item, float width)
        {
            item.GetComponent<SpriteRenderer>().SetWidth(width);
        }
        static public void SetPlanarSpriteHeight(this Transform item, float height)
        {
            item.GetComponent<SpriteRenderer>().SetHeight(height);
        }

        static public Vector2 GetPlanarSpriteSize(this Transform item)
        {
            return item.GetComponent<SpriteRenderer>().GetSize();
        }
    }
}