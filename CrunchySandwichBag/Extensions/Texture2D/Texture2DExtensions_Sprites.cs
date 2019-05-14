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
    static public class Texture2DExtensions_Sprites
    {
        static public IEnumerable<Sprite> GetSprites(this Texture2D item)
        {
            return item.GetAssetCohabitants().Convert<UnityEngine.Object, Sprite>();
        }
    }
}