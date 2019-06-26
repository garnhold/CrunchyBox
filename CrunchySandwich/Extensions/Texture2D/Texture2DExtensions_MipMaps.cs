using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Texture2DExtensions_MipMaps
    {
        static public bool HasMipMaps(this Texture2D item)
        {
            if (item.mipmapCount >= 2)
                return true;

            return false;
        }
    }
}