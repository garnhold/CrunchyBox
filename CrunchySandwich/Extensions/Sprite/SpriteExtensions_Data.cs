using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class SpriteExtensions_Data
    {
        static public Texture2D Sideload(this Sprite item)
        {
            return item.texture.IfNotNull(t => t.Sideload().GetSubTexture(item.rect));
        }
    }
}