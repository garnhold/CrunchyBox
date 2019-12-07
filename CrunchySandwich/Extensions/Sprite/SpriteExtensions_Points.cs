using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class SpriteExtensions_Points
    {
        static public Vector2 GetWorldCenter(this Sprite item)
        {
            return item.GetWorldSize() * 0.5f - item.pivot * item.GetUnitsPerPixel();
        }

        static public Vector2 GetWorldBottomCenter(this Sprite item)
        {
            return item.GetWorldCenter().GetWithAdjustedY(-0.5f * item.GetWorldHeight());
        }
        static public Vector2 GetWorldTopCenter(this Sprite item)
        {
            return item.GetWorldCenter().GetWithAdjustedY(0.5f * item.GetWorldHeight());
        }
        static public Vector2 GetWorldLeftCenter(this Sprite item)
        {
            return item.GetWorldCenter().GetWithAdjustedX(-0.5f * item.GetWorldWidth());
        }
        static public Vector2 GetWorldRightCenter(this Sprite item)
        {
            return item.GetWorldCenter().GetWithAdjustedX(0.5f * item.GetWorldWidth());
        }

        static public Vector2 GetWorldBottomLeft(this Sprite item)
        {
            return item.GetWorldCenter() - item.GetWorldSize() * 0.5f;
        }
        static public Vector2 GetWorldBottomRight(this Sprite item)
        {
            return item.GetWorldCenter() + item.GetWorldSize().GetWithFlippedY() * 0.5f;
        }
        static public Vector2 GetWorldTopLeft(this Sprite item)
        {
            return item.GetWorldCenter() + item.GetWorldSize().GetWithFlippedX() * 0.5f;
        }
        static public Vector2 GetWorldTopRight(this Sprite item)
        {
            return item.GetWorldCenter() + item.GetWorldSize() * 0.5f;
        }
    }
}