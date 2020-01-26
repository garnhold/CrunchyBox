using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class RectExtensions_Spacar
    {
        static public Bounds GetSpacar(this Rect item)
        {
            return new Bounds(item.center, item.size);
        }
    }
}