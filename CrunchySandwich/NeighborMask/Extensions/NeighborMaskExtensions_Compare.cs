using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class NeighborMaskExtensions_Compare
    {
        static public byte GetComplexity(this NeighborMask item)
        {
            return item.GetBits().GetNumberBits();
        }

        static public bool CanBeUsedFor(this NeighborMask item, NeighborMask target)
        {
            if (item.GetBits().HasNoOtherBits(target.GetBits()))
                return true;

            return false;
        }
    }
}