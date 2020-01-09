using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class OctoMaskExtensions_GetWith
    {
        static public OctoMask GetWithBitAt(this OctoMask item, int dx, int dy)
        {
            return new OctoMask(item.GetBits().GetBitUnion(OctoMaskExtensions.GetBitValue(dx, dy)));
        }

        static public OctoMask GetWithoutBitAt(this OctoMask item, int dx, int dy)
        {
            return new OctoMask(item.GetBits().GetBitExclusion(OctoMaskExtensions.GetBitValue(dx, dy)));
        }
    }
}