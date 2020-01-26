using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Texture2DExtensions_Size
    {
        static public Vector2 GetSize(this Texture2D item)
        {
            return new Vector2(item.width, item.height);
        }

        static public int GetNumberPixels(this Texture2D item)
        {
            return item.width * item.height;
        }
    }
}