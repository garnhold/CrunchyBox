using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class RectTransformExtensions_Size
    {
        static public Vector2 GetSize(this RectTransform item)
        {
            return item.rect.GetSize().GetComponentMultiply(item.GetPlanarScale());
        }
    }
}