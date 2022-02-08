using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class Texture2DExtensions_Sprite
    {
        static public Sprite CreateSprite(this Texture2D item, Rect rect, Vector2 unit_pivot)
        {
            return Sprite.Create(item, rect, unit_pivot);
        }

        static public Sprite CreateCenterSprite(this Texture2D item, Rect rect)
        {
            return item.CreateSprite(rect, new Vector2(0.5f, 0.5f));
        }

        static public Sprite CreateCenterSprite(this Texture2D item)
        {
            return item.CreateCenterSprite(item.GetRect());
        }

        static public IEnumerable<Sprite> CreateCenterSprites(this Texture2D item, IEnumerable<Rect> rects)
        {
            return rects.Convert(r => item.CreateCenterSprite(r));
        }
    }
}