using System;
using System.IO;

using UnityEngine;

namespace CrunchySandwich
{
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
    }
}