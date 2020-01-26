using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_Angle_Percent
    {
        static public VectorF2 CreateDirection(float percent)
        {
            return new VectorF2(TrigPercent.Cos(percent), TrigPercent.Sin(percent));
        }

        static public float GetAngleInPercent(this VectorF2 item)
        {
            return TrigPercent.Atan2(item.y, item.x);
        }

        static public float GetAngleInPercentDifference(this VectorF2 item, VectorF2 other)
        {
            return item.GetAngleInPercent().GetPercentAngleDifference(other.GetAngleInPercent());
        }

        static public float GetAngleInPercentDistance(this VectorF2 item, VectorF2 other)
        {
            return item.GetAngleInPercent().GetPercentAngleDistance(other.GetAngleInPercent());
        }

        static public VectorF2 GetAdjustDirectionAngleInPercent(this VectorF2 item, float adjustment)
        {
            return CreateDirection(item.GetAngleInPercent() + adjustment);
        }

        static public VectorF2 GetJitteredDirectionAngleInPercent(this VectorF2 item, float magnitude)
        {
            return item.GetAdjustDirectionAngleInPercent(RandFloat.GetMagnitude(magnitude));
        }
    }
}