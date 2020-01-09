using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class TransformExtensions_Planar_Scale
    {
        static public void ScalePlanarScale(this Transform item, float scale)
        {
            item.SetPlanarScale(item.GetPlanarScale() * scale);
        }
        static public void ScaleLocalPlanarScale(this Transform item, float scale)
        {
            item.SetLocalPlanarScale(item.GetLocalPlanarScale() * scale);
        }
    }
}