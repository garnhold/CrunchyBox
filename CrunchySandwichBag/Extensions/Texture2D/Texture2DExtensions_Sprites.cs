using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    static public class Texture2DExtensions_Sprites
    {
        static public IEnumerable<Sprite> GetSprites(this Texture2D item)
        {
            return item.GetAssetCohabitants()
                .Convert<UnityEngine.Object, Sprite>()
                .NaturalSort(s => s.name);
        }

        static public Sprite GetSpriteById(this Texture2D item, string id)
        {
            return item.GetSprites().FindFirst(s => s.GetSpriteId() == id);
        }
    }
}