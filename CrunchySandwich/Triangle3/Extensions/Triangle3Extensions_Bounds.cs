using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class Triangle3Extensions_Bounds
    {
        static public Bounds GetBounds(this Triangle3 item)
        {
            return BoundsExtensions.CreateWithPoints(item.GetPoints());
        }
    }
}