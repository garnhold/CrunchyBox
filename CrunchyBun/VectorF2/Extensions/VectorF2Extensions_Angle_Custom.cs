using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class VectorF2Extensions_Angle_Custom
    {
        static public VectorF2 CreateDirection(float x, float period)
        {
            return new VectorF2(TrigCustom.Cos(x, period), TrigCustom.Sin(x, period));
        }

        static public float GetAngleInCustom(this VectorF2 item, float period)
        {
            return TrigCustom.Atan2(item.y, item.x, period);
        }

        static public float GetAngleInCustomDifference(this VectorF2 item, VectorF2 other, float period)
        {
            return item.GetAngleInCustom(period).GetAngleDifference(other.GetAngleInCustom(period), period);
        }

        static public float GetAngleInCustomDistance(this VectorF2 item, VectorF2 other, float period)
        {
            return item.GetAngleInCustom(period).GetAngleDistance(other.GetAngleInCustom(period), period);
        }

        static public VectorF2 GetAdjustDirectionAngleInCustom(this VectorF2 item, float adjustment, float period)
        {
            return CreateDirection(item.GetAngleInCustom(period) + adjustment, period);
        }

        static public VectorF2 GetJitteredDirectionAngleInCustom(this VectorF2 item, float magnitude, float period)
        {
            return item.GetAdjustDirectionAngleInCustom(RandFloat.GetMagnitude(magnitude), period);
        }
    }
}