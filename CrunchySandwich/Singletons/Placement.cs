using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Placement
    {
        static public bool PlaceOnFloor(Process<RaycastHit> process, Vector3 position, int layer_mask = IntBits.ALL_BITS)
        {
            RaycastHit hit;

            if (new Ray(position, Vector3.down).CastAgainstOpposingDirection(out hit, float.PositiveInfinity, layer_mask))
            {
                process(hit);
                return true;
            }

            return false;
        }
    }
}