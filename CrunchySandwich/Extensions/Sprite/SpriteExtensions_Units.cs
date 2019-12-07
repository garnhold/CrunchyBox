using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class SpriteExtensions_Units
    {
        static public float GetUnitsPerPixel(this Sprite item)
        {
            return 1.0f / item.pixelsPerUnit;
        }
    }
}