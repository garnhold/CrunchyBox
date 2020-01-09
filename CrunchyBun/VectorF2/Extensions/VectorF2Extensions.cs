using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class VectorF2Extensions
    {
        static public VectorF2 CreateDirectionFromRadians(float radians)
        {
            return new VectorF2(TrigRadian.Cos(radians), TrigRadian.Sin(radians));
        }

        static public VectorF2 CreateDirectionFromDegrees(float degrees)
        {
            return new VectorF2(TrigDegree.Cos(degrees), TrigDegree.Sin(degrees));
        }

        static public VectorF2 CreateDirectionFromPercent(float percent)
        {
            return new VectorF2(TrigPercent.Cos(percent), TrigPercent.Sin(percent));
        }
    }
}