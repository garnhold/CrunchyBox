using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class RectF2Extensions_RectInt
    {
        static public RectInt GetRectInt(this RectF2 item)
        {
            return new RectInt(
                item.GetLowerLeftPoint().GetVector2Int(), 
                item.GetSize().GetVector2Int()
            );
        }
    }
}