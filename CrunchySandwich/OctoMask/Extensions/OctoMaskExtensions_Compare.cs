using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class OctoMaskExtensions_Compare
    {
        static public byte GetComplexity(this OctoMask item)
        {
            return item.GetBits().GetNumberBits();
        }

        static public bool HasNoOtherBits(this OctoMask item, OctoMask target)
        {
            if (item.GetBits().HasNoOtherBits(target.GetBits()))
                return true;

            return false;
        }
    }
}