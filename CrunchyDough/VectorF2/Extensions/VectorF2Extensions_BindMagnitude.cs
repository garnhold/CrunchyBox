using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_BindMagnitude
    {
        static public VectorF2 BindMagnitudeAbove(this VectorF2 item, float lower)
        {
            float magnitude;

            return item.GetNormalized(out magnitude) * magnitude.BindAbove(lower);
        }

        static public VectorF2 BindMagnitudeBelow(this VectorF2 item, float upper)
        {
            float magnitude;

            return item.GetNormalized(out magnitude) * magnitude.BindBelow(upper);
        }

        static public VectorF2 BindMagnitudeBetween(this VectorF2 item, float value1, float value2)
        {
            float magnitude;

            return item.GetNormalized(out magnitude) * magnitude.BindBetween(value1, value2);
        }
    }
}