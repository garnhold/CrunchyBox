using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{   
    static public class VectorF2Extensions
    {
        static public VectorF2 CreateDirectionFromRadians(float radians)
        {
            return VectorF2Extensions_Angle_Radians.CreateDirection(radians);
        }

        static public VectorF2 CreateDirectionFromDegrees(float degrees)
        {
            return VectorF2Extensions_Angle_Degrees.CreateDirection(degrees);
        }

        static public VectorF2 CreateDirectionFromPercent(float percent)
        {
            return VectorF2Extensions_Angle_Percent.CreateDirection(percent);
        }
    }
}