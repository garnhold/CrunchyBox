using System;

namespace Crunchy.Dough
{
    static public class DurationExtensions_String
    {
        static public string ToComfortableString(this Duration item)
        {
            DurationUnit unit = item.GetComfortableDurationUnit();
            float length = item.GetLength(unit);

            if (length < float.MaxValue)
                return length.ToString("F4") + unit.GetUnitSuffix();

            return "forever";
        }

        static public string ToDaysHoursMinutesSecondsMillisecondsString(this Duration item)
        {
            int days;
            int hours;
            int minutes;
            int seconds;
            int milliseconds;

            item.GetDaysHoursMinutesSecondsMilliseconds(out days, out hours, out minutes, out seconds, out milliseconds);

            return days + ":" + 
                hours.ToString("D2") + ":" + 
                minutes.ToString("D2") + ":" + 
                seconds.ToString("D2") + "." + 
                milliseconds.ToString("D3");
        }
        static public string ToHoursMinutesSecondsMillisecondsString(this Duration item)
        {
            int hours;
            int minutes;
            int seconds;
            int milliseconds;

            item.GetHoursMinutesSecondsMilliseconds(out hours, out minutes, out seconds, out milliseconds);

            return hours + ":" +
                minutes.ToString("D2") + ":" +
                seconds.ToString("D2") + "." +
                milliseconds.ToString("D3");
        }
        static public string ToMinutesSecondsMillisecondsString(this Duration item)
        {
            int minutes;
            int seconds;
            int milliseconds;

            item.GetMinutesSecondsMilliseconds(out minutes, out seconds, out milliseconds);

            return minutes + ":" +
                seconds.ToString("D2") + "." +
                milliseconds.ToString("D3");
        }
        static public string ToSecondsMillisecondsString(this Duration item)
        {
            int seconds;
            int milliseconds;

            item.GetSecondsMilliseconds(out seconds, out milliseconds);

            return seconds + "." +
                milliseconds.ToString("D3");
        }

        static public string ToDaysHoursMinutesSecondsString(this Duration item)
        {
            int days;
            int hours;
            int minutes;
            int seconds;

            item.GetDaysHoursMinutesSeconds(out days, out hours, out minutes, out seconds);

            return days + ":" +
                hours.ToString("D2") + ":" +
                minutes.ToString("D2") + ":" +
                seconds.ToString("D2");
        }
        static public string ToHoursMinutesSecondsString(this Duration item)
        {
            int hours;
            int minutes;
            int seconds;

            item.GetHoursMinutesSeconds(out hours, out minutes, out seconds);

            return hours + ":" +
                minutes.ToString("D2") + ":" +
                seconds.ToString("D2");
        }
        static public string ToMinutesSecondsString(this Duration item)
        {
            int minutes;
            int seconds;

            item.GetMinutesSeconds(out minutes, out seconds);

            return minutes + ":" +
                seconds.ToString("D2");
        }

        static public string ToDaysHoursMinutesString(this Duration item)
        {
            int days;
            int hours;
            int minutes;

            item.GetDaysHoursMinutes(out days, out hours, out minutes);

            return days + ":" +
                hours.ToString("D2") + ":" +
                minutes.ToString("D2");
        }
        static public string ToHoursMinutesString(this Duration item)
        {
            int hours;
            int minutes;

            item.GetHoursMinutes(out hours, out minutes);

            return hours + ":" +
                minutes.ToString("D2");
        }
    }
}