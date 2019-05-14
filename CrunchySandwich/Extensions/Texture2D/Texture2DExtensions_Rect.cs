using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Texture2DExtensions_Rect
    {
        static public Rect GetRect(this Texture2D item)
        {
            return new Rect(0.0f, 0.0f, item.width, item.height);
        }
    }
}