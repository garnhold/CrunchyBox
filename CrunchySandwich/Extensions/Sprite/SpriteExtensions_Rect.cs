using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class SpriteExtensions_Rect
    {
        static public Rect GetSpriteSpaceRect(this Sprite item)
        {
            return RectExtensions.CreateCenterRect(Vector2.zero, item.GetTextureSize());
        }

        static public Rect GetNormalizedTextureRect(this Sprite item)
        {
            return item.rect.GetNormalized(item.texture.GetSize());
        }
    }
}