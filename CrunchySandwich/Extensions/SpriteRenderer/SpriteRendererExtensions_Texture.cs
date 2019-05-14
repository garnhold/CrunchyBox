using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class SpriteRendererExtensions_Texture
    {
        static public void SetCenterTexture(this SpriteRenderer item, Texture2D texture)
        {
            if (item.sprite == null || item.sprite.texture != texture)
                item.sprite = texture.CreateCenterSprite();
        }
    }
}