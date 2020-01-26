using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_Direction
    {
        static public VectorF2 GetDirection(this VectorF2 item, VectorF2 target)
        {
            return (target - item).GetNormalized();
        }

        static public VectorF2 GetDirection(this VectorF2 item, VectorF2 target, out float distance)
        {
            return (target - item).GetNormalized(out distance);
        }

        static public bool IsComplyingDirection(this VectorF2 item, VectorF2 direction)
        {
            if (item.GetDot(direction) > 0.0f)
                return true;

            return false;
        }

        static public bool IsOpposingDirection(this VectorF2 item, VectorF2 direction)
        {
            if (item.GetDot(direction) < 0.0f)
                return true;

            return false;
        }
    }
}