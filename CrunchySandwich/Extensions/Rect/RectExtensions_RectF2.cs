using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class RectExtensions_RectF2
    {
        static public RectF2 GetRectF2(this Rect item)
        {
            return RectF2Extensions.CreateCenterRectF2(
                item.GetLowerLeftPoint().GetVectorF2(), 
                item.GetSize().GetVectorF2()
            );
        }
    }
}