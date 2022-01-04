using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class RectExtensions_RectI2
    {
        static public RectI2 GetRectI2(this Rect item)
        {
            return RectI2Extensions.CreateLowerLeftRectI2(
                item.GetLowerLeftPoint().GetVectorI2(), 
                item.GetSize().GetVectorI2()
            );
        }
    }
}