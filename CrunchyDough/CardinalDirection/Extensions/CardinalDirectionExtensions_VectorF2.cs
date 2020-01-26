using System;

namespace Crunchy.Dough
{    
    static public class CardinalDirectionExtensions_VectorF2
    {
        static public VectorF2 GetVectorF2(this CardinalDirection item)
        {
            switch (item)
            {
                case CardinalDirection.Right: return VectorF2.RIGHT;
                case CardinalDirection.Up: return VectorF2.UP;
                case CardinalDirection.Left: return VectorF2.LEFT;
                case CardinalDirection.Down: return VectorF2.DOWN;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}