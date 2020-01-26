using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class FaceExtensions_Rect
    {
        static public Rect GetRect(this Face item)
        {
            return RectExtensions.CreateMinMaxRect(item.v0, item.v1);
        }
    }
}