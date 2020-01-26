using System;

namespace Crunchy.Dough
{    
    static public class CardinalOrdinalDirectionExtensions_VectorF2
    {
        static public VectorF2 GetVectorF2(this CardinalOrdinalDirection item)
        {
            switch (item)
            {
                case CardinalOrdinalDirection.Right: return VectorF2.RIGHT;
                case CardinalOrdinalDirection.RightUp: return VectorF2.RIGHT_UP;
                case CardinalOrdinalDirection.Up: return VectorF2.UP;
                case CardinalOrdinalDirection.LeftUp: return VectorF2.LEFT_UP;
                case CardinalOrdinalDirection.Left: return VectorF2.LEFT;
                case CardinalOrdinalDirection.LeftDown: return VectorF2.LEFT_DOWN;
                case CardinalOrdinalDirection.Down: return VectorF2.DOWN;
                case CardinalOrdinalDirection.RightDown: return VectorF2.RIGHT_DOWN;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}