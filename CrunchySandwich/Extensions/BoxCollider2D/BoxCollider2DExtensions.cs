using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class BoxCollider2DExtensions
    {
        static public void SetRect(this BoxCollider2D item, Rect rect)
        {
            item.offset = rect.center;
            item.size = rect.size;
        }

        static public Rect GetRect(this BoxCollider2D item)
        {
            return RectExtensions.CreateCenterRect(item.offset, item.size);
        }
    }
}