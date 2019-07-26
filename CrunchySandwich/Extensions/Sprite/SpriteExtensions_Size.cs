using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class SpriteExtensions_Size
    {
        static public Vector2 GetTextureSize(this Sprite item)
        {
            return item.rect.size;
        }

        static public float GetTextureWidth(this Sprite item)
        {
            return item.GetTextureSize().x;
        }
        static public float GetTextureHeight(this Sprite item)
        {
            return item.GetTextureSize().y;
        }

        static public Vector2 GetWorldSize(this Sprite item)
        {
            return item.bounds.GetPlanarSize();
        }

        static public float GetWorldWidth(this Sprite item)
        {
            return item.GetWorldSize().x;
        }
        static public float GetWorldHeight(this Sprite item)
        {
            return item.GetWorldSize().y;
        }
    }
}