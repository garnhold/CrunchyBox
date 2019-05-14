using System;

namespace CrunchyBun
{
    static public class RandVectorI2
    {
        static public readonly RandVectorI2Source SOURCE = new RandVectorI2Source(RandFloat.SOURCE);

        static public VectorI2 Get()
        {
            return SOURCE.Get();
        }

        static public VectorI2 GetMagnitude(VectorI2 m)
        {
            return SOURCE.GetMagnitude(m);
        }

        static public VectorI2 GetOffset(VectorI2 radius)
        {
            return SOURCE.GetOffset(radius);
        }

        static public VectorI2 GetVariance(VectorI2 center, VectorI2 radius)
        {
            return SOURCE.GetVariance(center, radius);
        }

        static public VectorI2 GetBetween(VectorI2 a, VectorI2 b)
        {
            return SOURCE.GetBetween(a, b);
        }
    }
}