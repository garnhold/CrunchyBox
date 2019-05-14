using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class SpriteExtensions_Data
    {
        static public Texture2D Sideload(this Sprite item)
        {
            return item.texture.IfNotNull(t => t.Sideload().GetSubTexture(item.rect));
        }
    }
}