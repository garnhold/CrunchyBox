using System;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;
    
    static public class HatPositionExtensions
    {
        static public VectorF2 GetVectorF2(this HatPosition item)
        {
            switch (item)
            {
                case HatPosition.Centered: return VectorF2.ZERO;
                case HatPosition.Down: return VectorF2.DOWN;
                case HatPosition.DownLeft: return VectorF2.LEFT_DOWN;
                case HatPosition.DownRight: return VectorF2.RIGHT_DOWN;
                case HatPosition.Left: return VectorF2.LEFT;
                case HatPosition.Right: return VectorF2.RIGHT;
                case HatPosition.Up: return VectorF2.UP;
                case HatPosition.UpLeft: return VectorF2.LEFT_UP;
                case HatPosition.UpRight: return VectorF2.RIGHT_UP;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}