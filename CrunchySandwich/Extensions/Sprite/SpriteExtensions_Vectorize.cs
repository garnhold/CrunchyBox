using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class SpriteExtensions_Vectorize
    {
        static public IEnumerable<List<Vector2>> ScaledVectorize(this Sprite item, float alpha_threshold, int maximum_gap, float pre_scale)
        {
            return item.Sideload().Vectorize(alpha_threshold, maximum_gap, pre_scale, item.GetUnitsPerPixel(), -item.pivot * item.GetUnitsPerPixel(), new Vector2(0.5f, 0.5f));
        }

        static public IEnumerable<List<Vector2>> UnscaledVectorize(this Sprite item, float alpha_threshold, int maximum_gap, float pre_scale)
        {
            return item.Sideload().Vectorize(alpha_threshold, maximum_gap, pre_scale, 1.0f, -item.pivot, new Vector2(0.5f, 0.5f));
        }
    }
}