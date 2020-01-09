using System;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class FloatExtensions_Angle_Near
    {
        static public void GetAsNearAngles(this float item, float angle, float period, out float item_output, out float angle_output)
        {
            float half_period = period * 0.5f;
            
            item_output = item.GetLooped(period);
            angle_output = angle.GetLooped(period);

            if (item_output < angle_output)
            {
                if (item_output + half_period < angle_output)
                    angle_output = angle_output - period;
            }
            else
            {
                if (angle_output + half_period < item_output)
                    item_output = item_output - period;
            }
        }
        static public void GetAsNearAnglesInRadians(this float item, float angle, out float item_output, out float angle_output)
        {
            item.GetAsNearAngles(angle, Mathq.FULL_REVOLUTION_RADIANS, out item_output, out angle_output);
        }
        static public void GetAsNearAnglesInDegrees(this float item, float angle, out float item_output, out float angle_output)
        {
            item.GetAsNearAngles(angle, Mathq.FULL_REVOLUTION_DEGREES, out item_output, out angle_output);
        }
        static public void GetAsNearAnglesInPercent(this float item, float angle, out float item_output, out float angle_output)
        {
            item.GetAsNearAngles(angle, Mathq.FULL_REVOLUTION_PERCENT, out item_output, out angle_output);
        }

        static public void GetAsNearAngles(this float item, float angle_a, float angle_b, float period, out float item_output, out float angle_a_output, out float angle_b_output)
        {
            item_output = item.GetLooped(period);
            angle_a_output = angle_a.GetLooped(period);
            angle_b_output = angle_b.GetLooped(period);

            if (angle_a_output <= angle_b_output)
            {
                if (item_output <= angle_a_output)
                {
                    item_output += period;
                    angle_a_output += period;
                }
                else if (item_output >= angle_b_output)
                {
                    angle_a_output += period;
                }
            }
            else
            {
                if (item_output <= angle_b_output)
                {
                    item_output += period;
                    angle_b_output += period;
                }
                else if (item_output >= angle_a_output)
                {
                    angle_b_output += period;
                }
            }
        }
        static public void GetAsNearAnglesInRadians(this float item, float angle_a, float angle_b, out float item_output, out float angle_a_output, out float angle_b_output)
        {
            item.GetAsNearAngles(angle_a, angle_b, Mathq.FULL_REVOLUTION_RADIANS, out item_output, out angle_a_output, out angle_b_output);
        }
        static public void GetAsNearAnglesInDegrees(this float item, float lower, float upper, out float item_output, out float angle_a_output, out float angle_b_output)
        {
            item.GetAsNearAngles(lower, upper, Mathq.FULL_REVOLUTION_DEGREES, out item_output, out angle_a_output, out angle_b_output);
        }
        static public void GetAsNearAnglesInPercent(this float item, float lower, float upper, out float item_output, out float angle_a_output, out float angle_b_output)
        {
            item.GetAsNearAngles(lower, upper, Mathq.FULL_REVOLUTION_PERCENT, out item_output, out angle_a_output, out angle_b_output);
        }
    }
}