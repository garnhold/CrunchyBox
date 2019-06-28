using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Texture2DExtensions_Vectorize
    {
        static public IEnumerable<List<Vector2>> Vectorize(this Texture2D item, float alpha_threshold, int maximum_gap, float pre_scale, float scale, Vector2 offset)
        {
            if (pre_scale != 1.0f)
                item = item.GetScaledByFactor(pre_scale);

            return item.CreateSolidGrid(alpha_threshold).Vectorize(maximum_gap, scale / pre_scale, offset);
        }

        static public IEnumerable<List<Vector2>> Vectorize(this Texture2D item, float alpha_threshold, int maximum_gap, float pre_scale, float scale, Vector2 offset, Vector2 cell_center)
        {
            return item.Vectorize(alpha_threshold, maximum_gap, pre_scale, scale, offset + cell_center * (scale / pre_scale));
        }
    }
}