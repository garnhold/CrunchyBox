using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class SpriteExtensions_Aspect
    {
        static public float GetAspect(this Sprite item)
        {
            return item.GetTextureHeight() / item.GetTextureWidth();
        }
    }
}