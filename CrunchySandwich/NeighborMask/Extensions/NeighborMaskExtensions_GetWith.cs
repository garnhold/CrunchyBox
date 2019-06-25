using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class NeighborMaskExtensions_GetWith
    {
        static public NeighborMask GetWithBitAt(this NeighborMask item, int dx, int dy)
        {
            return new NeighborMask(item.GetBits().GetBitUnion(NeighborMaskExtensions.GetBitValue(dx, dy)));
        }

        static public NeighborMask GetWithoutBitAt(this NeighborMask item, int dx, int dy)
        {
            return new NeighborMask(item.GetBits().GetBitExclusion(NeighborMaskExtensions.GetBitValue(dx, dy)));
        }
    }
}