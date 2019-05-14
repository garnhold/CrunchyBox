using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class RectTransformExtensions_Size
    {
        static public Vector2 GetSize(this RectTransform item)
        {
            return item.rect.GetSize().GetComponentMultiply(item.GetPlanarScale());
        }
    }
}