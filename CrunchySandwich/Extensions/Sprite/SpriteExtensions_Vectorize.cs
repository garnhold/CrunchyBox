using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class SpriteExtensions_Vectorize
    {
        static public IEnumerable<List<Vector2>> Vectorize(this Sprite item, float alpha_threshold, int maximum_gap)
        {
            return item.Sideload().Vectorize(alpha_threshold, maximum_gap, item.GetUnitsPerPixel(), item.pivot * item.GetUnitsPerPixel());
        }
    }
}