using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class NeighborMaskExtensions_Has
    {
        static public bool HasBitAt(this NeighborMask item, int dx, int dy)
        {
            int index;

            if (NeighborMaskExtensions.TryGetBitIndex(dx, dy, out index))
            {
                if (item.GetBits().HasNthBit(index))
                    return true;
            }

            return false;
        }
    }
}