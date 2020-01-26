using System;

namespace Crunchy.Dough
{    
    static public class RandFloat
    {
        static public readonly RandFloatSource SOURCE = new RandFloatSource_IntSource(RandInt.SOURCE);

        static public float Get()
        {
            return SOURCE.Get();
        }

        static public float GetMagnitude(float m)
        {
            return SOURCE.GetMagnitude(m);
        }

        static public float GetSign()
        {
            return SOURCE.GetSign();
        }

        static public float GetOffset(float radius)
        {
            return SOURCE.GetOffset(radius);
        }

        static public float GetVariance(float x, float radius)
        {
            return SOURCE.GetVariance(x, radius);
        }

        static public float GetBetween(float a, float b)
        {
            return SOURCE.GetBetween(a, b);
        }

        static public float GetBetween(FloatRange range)
        {
            return SOURCE.GetBetween(range);
        }
    }
}