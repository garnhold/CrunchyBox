using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class FloatExtensions_Angle_MoveTowards
    {
        static public bool GetMoveTowardsAngle(this float item, float target, float period, float amount, out float output)
        {
            item.GetAsNearAngles(target, period, out item, out target);

            return item.GetMoveTowards(target, amount, out output);
        }

        static public bool GetMoveTowardsAngleInRadians(this float item, float target, float amount, out float output)
        {
            return item.GetMoveTowardsAngle(target, Mathq.FULL_REVOLUTION_RADIANS, amount, out output);
        }

        static public bool GetMoveTowardsAngleInDegrees(this float item, float target, float amount, out float output)
        {
            return item.GetMoveTowardsAngle(target, Mathq.FULL_REVOLUTION_DEGREES, amount, out output);
        }

        static public bool GetMoveTowardsAngleInPercent(this float item, float target, float amount, out float output)
        {
            return item.GetMoveTowardsAngle(target, Mathq.FULL_REVOLUTION_PERCENT, amount, out output);
        }
    }
}