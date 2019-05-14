using System;

using UnityEngine;

namespace CrunchySandwich
{
    static public class BoundsExtensions_Footprint
    {
        static public float GetFootprintArea(this Bounds item)
        {
            return item.size.x * item.size.z;
        }
    }
}