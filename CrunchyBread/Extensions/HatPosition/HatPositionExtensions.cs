using System;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;
    
    static public class HatPositionExtensions
    {
        static public VectorI2 GetVectorI2(this HatPosition item)
        {
            switch (item)
            {
                case HatPosition.Centered: return VectorI2.ZERO;
                case HatPosition.Down: return VectorI2.DOWN;
                case HatPosition.DownLeft: return VectorI2.LEFT_DOWN;
                case HatPosition.DownRight: return VectorI2.RIGHT_DOWN;
                case HatPosition.Left: return VectorI2.LEFT;
                case HatPosition.Right: return VectorI2.RIGHT;
                case HatPosition.Up: return VectorI2.UP;
                case HatPosition.UpLeft: return VectorI2.LEFT_UP;
                case HatPosition.UpRight: return VectorI2.RIGHT_UP;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}