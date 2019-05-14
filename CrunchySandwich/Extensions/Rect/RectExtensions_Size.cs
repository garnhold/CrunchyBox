using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class RectExtensions_Size
    {
        static public Vector2 GetSize(this Rect item)
        {
            return new Vector2(item.width, item.height);
        }
    }
}