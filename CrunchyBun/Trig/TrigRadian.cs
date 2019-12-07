using System;

namespace Crunchy.Bun
{
    static public class TrigRadian
    {
        static private PeriodicFunctionApproximation SIN_TABLE = new PeriodicFunctionApproximation(Mathq.PI2, 64, x => (float)Math.Sin(x));
        static private PeriodicFunctionApproximation COS_TABLE = new PeriodicFunctionApproximation(Mathq.PI2, 64, x => (float)Math.Cos(x));

        static public float Sin(float radians)
        {
            return SIN_TABLE.Evaluate(radians);
        }

        static public float Cos(float radians)
        {
            return COS_TABLE.Evaluate(radians);
        }

        static public float Atan2(float y, float x)
        {
            return (float)Math.Atan2(y, x);
        }
    }
}