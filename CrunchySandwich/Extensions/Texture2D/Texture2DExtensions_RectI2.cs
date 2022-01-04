using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class Texture2DExtensions_RectI2
    {
        static public RectI2 GetRectI2(this Texture2D item)
        {
            return RectI2Extensions.CreateLowerLeftRectI2(0, 0, item.width, item.height);
        }
    }
}