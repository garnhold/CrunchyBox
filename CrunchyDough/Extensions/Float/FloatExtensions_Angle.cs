using System;

namespace Crunchy.Dough
{    
    static public class FloatExtensions_Angle
    {
        static public float GetRadianAngle(this float item)
        {
            return item.GetLooped(Mathq.PI2);
        }

        static public float GetDegreeAngle(this float item)
        {
            return item.GetLooped(360.0f);
        }

        static public float GetPercentAngle(this float item)
        {
            return item.GetLooped(1.0f);
        }
    }
}