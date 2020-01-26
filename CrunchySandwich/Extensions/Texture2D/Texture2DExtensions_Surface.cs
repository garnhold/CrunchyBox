using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    using Sauce;
    
    static public class Texture2DExtensions_Surface
    {
        static public Surface<Color> GetSurface(this Texture2D item)
        {
            return new Surface_Texture2D(item);
        }
    }
}