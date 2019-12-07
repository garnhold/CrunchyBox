using System;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class HorizontalDirectionExtensions_VectorF2
    {
        static public VectorF2 GetVectorF2(this HorizontalDirection item)
        {
            switch (item)
            {
                case HorizontalDirection.Right: return VectorF2.RIGHT;
                case HorizontalDirection.Left: return VectorF2.LEFT;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}