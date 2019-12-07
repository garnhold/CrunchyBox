using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    using Noodle;
    
    static public class VectorF2Extensions_Angle_Radians
    {
        static public VectorF2 CreateDirection(float radians)
        {
            return new VectorF2(TrigRadian.Cos(radians), TrigRadian.Sin(radians));
        }

        static public float GetAngleInRadians(this VectorF2 item)
        {
            return TrigRadian.Atan2(item.y, item.x);
        }

        static public float GetAngleInRadiansDifference(this VectorF2 item, VectorF2 other)
        {
            return item.GetAngleInRadians().GetRadianAngleDifference(other.GetAngleInRadians());
        }

        static public float GetAngleInRadiansDistance(this VectorF2 item, VectorF2 other)
        {
            return item.GetAngleInRadians().GetRadianAngleDistance(other.GetAngleInRadians());
        }

        static public VectorF2 GetAdjustDirectionAngleInRadians(this VectorF2 item, float adjustment)
        {
            return CreateDirection(item.GetAngleInRadians() + adjustment);
        }

        static public VectorF2 GetJitteredDirectionAngleInRadians(this VectorF2 item, float magnitude)
        {
            return item.GetAdjustDirectionAngleInRadians(RandFloat.GetMagnitude(magnitude));
        }
    }
}