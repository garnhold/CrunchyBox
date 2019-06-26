using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_IEnumerable_LoopInflate
    {
        static public IEnumerable<Vector2> OffsetInflateLoop(this IEnumerable<Vector2> item, float amount)
        {
            item = item.PrepareMultipass();

            Vector2 center = item.Average();

            return item.Convert(p => p + center.GetDirection(p) * amount);

            change this shit// so that it uses the implied normals etc. so that it works correctly
        }
    }
}