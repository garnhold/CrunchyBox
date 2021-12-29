using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class SpriteExtensions_Transform
    {
        static public Vector2 TransformNormalizedPoint(this Sprite item, Vector2 point)
        {
            return (point - item.GetNormalizedPivot()) * item.GetWorldSize();
        }
    }
}