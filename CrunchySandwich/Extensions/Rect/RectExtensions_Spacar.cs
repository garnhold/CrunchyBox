using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class RectExtensions_Spacar
    {
        static public Bounds GetSpacar(this Rect item)
        {
            return new Bounds(item.center, item.size);
        }
    }
}