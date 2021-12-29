using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class SpriteExtensions_Points
    {
        static public Vector2 GetWorldCenter(this Sprite item)
        {
            return item.TransformNormalizedPoint(new Vector2(0.5f, 0.5f));
        }

        static public Vector2 GetWorldBottomCenter(this Sprite item)
        {
            return item.TransformNormalizedPoint(new Vector2(0.5f, 0.0f));
        }
        static public Vector2 GetWorldTopCenter(this Sprite item)
        {
            return item.TransformNormalizedPoint(new Vector2(0.5f, 1.0f));
        }
        static public Vector2 GetWorldLeftCenter(this Sprite item)
        {
            return item.TransformNormalizedPoint(new Vector2(0.0f, 0.5f));
        }
        static public Vector2 GetWorldRightCenter(this Sprite item)
        {
            return item.TransformNormalizedPoint(new Vector2(1.0f, 0.5f));
        }

        static public Vector2 GetWorldBottomLeft(this Sprite item)
        {
            return item.TransformNormalizedPoint(new Vector2(0.0f, 0.0f));
        }
        static public Vector2 GetWorldBottomRight(this Sprite item)
        {
            return item.TransformNormalizedPoint(new Vector2(1.0f, 0.0f));
        }
        static public Vector2 GetWorldTopLeft(this Sprite item)
        {
            return item.TransformNormalizedPoint(new Vector2(0.0f, 1.0f));
        }
        static public Vector2 GetWorldTopRight(this Sprite item)
        {
            return item.TransformNormalizedPoint(new Vector2(1.0f, 1.0f));
        }
    }
}