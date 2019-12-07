using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class OctoMaskExtensions_Has
    {
        static public bool HasBitAt(this OctoMask item, int dx, int dy)
        {
            int index;

            if (OctoMaskExtensions.TryGetBitIndex(dx, dy, out index))
            {
                if (item.GetBits().HasNthBit(index))
                    return true;
            }

            return false;
        }
    }
}