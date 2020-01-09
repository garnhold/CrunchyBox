using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class BoundsExtensions_Volume
    {
        static public float GetVolume(this Bounds item)
        {
            return item.size.x * item.size.y * item.size.z;
        }
    }
}