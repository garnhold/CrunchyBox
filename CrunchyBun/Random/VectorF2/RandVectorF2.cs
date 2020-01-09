using System;

namespace Crunchy.Bun
{
    static public class RandVectorF2
    {
        static public readonly RandVectorF2Source SOURCE = new RandVectorF2Source(RandFloat.SOURCE);

        static public VectorF2 Get()
        {
            return SOURCE.Get();
        }

        static public VectorF2 GetMagnitude(VectorF2 m)
        {
            return SOURCE.GetMagnitude(m);
        }

        static public VectorF2 GetOffset(VectorF2 radius)
        {
            return SOURCE.GetOffset(radius);
        }

        static public VectorF2 GetVariance(VectorF2 center, VectorF2 radius)
        {
            return SOURCE.GetVariance(center, radius);
        }

        static public VectorF2 GetBetween(VectorF2 a, VectorF2 b)
        {
            return SOURCE.GetBetween(a, b);
        }

        static public VectorF2 GetNearLinePointByPercent(VectorF2 point1, VectorF2 point2, float percent, float radius)
        {
            return SOURCE.GetNearLinePointByPercent(point1, point2, percent, radius);
        }

        static public VectorF2 GetNearLinePoint(VectorF2 point1, VectorF2 point2, float distance, float radius)
        {
            return SOURCE.GetNearLinePoint(point1, point2, distance, radius);
        }

        static public VectorF2 GetNearLine(VectorF2 point1, VectorF2 point2, float radius)
        {
            return SOURCE.GetNearLine(point1, point2, radius);
        }
    }
}