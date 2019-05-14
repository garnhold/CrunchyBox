using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class TransformExtensions_Planar_Match
    {
        static public void MatchPlanarTransform(this Transform item, Transform target)
        {
            item.SetPlanarPosition(target.GetPlanarPosition());
            item.SetPlanarRotation(target.GetPlanarRotation());
            item.SetPlanarScale(target.GetPlanarScale());
        }
    }
}