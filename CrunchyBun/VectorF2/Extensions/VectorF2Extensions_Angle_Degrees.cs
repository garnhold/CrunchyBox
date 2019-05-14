using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchyBun
{
    static public class VectorF2Extensions_Angle_Degrees
    {
        static public VectorF2 CreateDirection(float degrees)
        {
            return new VectorF2(TrigDegree.Cos(degrees), TrigDegree.Sin(degrees));
        }

        static public float GetAngleInDegrees(this VectorF2 item)
        {
            return TrigDegree.Atan2(item.y, item.x);
        }

        static public float GetAngleInDegreesDifference(this VectorF2 item, VectorF2 other)
        {
            return item.GetAngleInDegrees().GetDegreeAngleDifference(other.GetAngleInDegrees());
        }

        static public float GetAngleInDegreesDistance(this VectorF2 item, VectorF2 other)
        {
            return item.GetAngleInDegrees().GetDegreeAngleDistance(other.GetAngleInDegrees());
        }

        static public VectorF2 GetAdjustDirectionAngleInDegrees(this VectorF2 item, float adjustment)
        {
            return CreateDirection(item.GetAngleInDegrees() + adjustment);
        }

        static public VectorF2 GetJitteredDirectionAngleInDegrees(this VectorF2 item, float magnitude)
        {
            return item.GetAdjustDirectionAngleInDegrees(RandFloat.GetMagnitude(magnitude));
        }
    }
}