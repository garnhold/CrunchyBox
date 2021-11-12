using System;

namespace Crunchy.Dough
{
    public struct Duration
    {
        private float milliseconds;

        public const float MILLISECONDS_PER_SECOND = 1000.0f;
        public const float SECONDS_PER_MINUTE = 60.0f;
        public const float MINUTES_PER_HOUR = 60.0f;
        public const float HOURS_PER_DAY = 24.0f;

        public const float MILLISECONDS_PER_MINUTE = MILLISECONDS_PER_SECOND * SECONDS_PER_MINUTE;
        public const float MILLISECONDS_PER_HOUR = MILLISECONDS_PER_MINUTE * MINUTES_PER_HOUR;
        public const float MILLISECONDS_PER_DAY = MILLISECONDS_PER_HOUR * HOURS_PER_DAY;

        public static readonly Duration Nothing = Duration.Milliseconds(0);

        static public Duration Milliseconds(long m)
        {
            return new Duration(m);
        }
        static public Duration Milliseconds(float m)
        {
            return new Duration(m);
        }
        static public Duration Seconds(float s)
        {
            return new Duration(s * MILLISECONDS_PER_SECOND);
        }
        static public Duration Minutes(float m)
        {
            return new Duration(m * MILLISECONDS_PER_MINUTE);
        }
        static public Duration Hours(float h)
        {
            return new Duration(h * MILLISECONDS_PER_HOUR);
        }
        static public Duration Days(float d)
        {
            return new Duration(d * MILLISECONDS_PER_DAY);
        }

        static public Duration Hertz(float hz)
        {
            return Seconds(1.0f / hz);
        }

        static public Duration Length(DurationUnit unit, float length)
        {
            switch (unit)
            {
                case DurationUnit.Milliseconds: return Milliseconds(length);
                case DurationUnit.Seconds: return Seconds(length);
                case DurationUnit.Minutes: return Minutes(length);
                case DurationUnit.Hours: return Hours(length);
                case DurationUnit.Days: return Days(length);

                case DurationUnit.Hertz: return Hertz(length);
            }

            throw new UnaccountedBranchException("unit", unit);
        }

        static public bool TryParse(string value, out Duration output)
        {
            double number;
            string units;

            if (value.TryParseMeasurement(out number, out units))
            {
                output = Length(DurationUnitExtensions_Suffix.GetUnitBySuffix(units), (float)number);
                return true;
            }

            output = default(Duration);
            return false;
        }

        static public Duration MinutesSeconds(float minutes, float seconds)
        {
            return Minutes(minutes) + Seconds(seconds);
        }

        static public Duration HoursMinutesSeconds(float hours, float minutes, float seconds)
        {
            return Hours(hours) + Minutes(minutes) + Seconds(seconds);
        }

        static public Duration DaysHoursMinutesSeconds(float days, float hours, float minutes, float seconds)
        {
            return Days(days) + Hours(hours) + Minutes(minutes) + Seconds(seconds);
        }

        static public Duration operator +(Duration d1, Duration d2) { return new Duration(d1.milliseconds + d2.milliseconds); }
        static public Duration operator -(Duration d1, Duration d2) { return new Duration(d1.milliseconds - d2.milliseconds); }

        static public Duration operator *(Duration d1, float s) { return new Duration(d1.milliseconds * s); }
        static public Duration operator /(Duration d1, float s) { return new Duration(d1.milliseconds / s); }

        static public float operator /(Duration d1, Duration d2) { return d1.milliseconds / d2.milliseconds; }

        static public bool operator ==(Duration d1, Duration d2) { return d1.milliseconds == d2.milliseconds; }
        static public bool operator !=(Duration d1, Duration d2) { return d1.milliseconds != d2.milliseconds; }
        static public bool operator <(Duration d1, Duration d2) { return d1.milliseconds < d2.milliseconds; }
        static public bool operator <=(Duration d1, Duration d2) { return d1.milliseconds <= d2.milliseconds; }
        static public bool operator >(Duration d1, Duration d2) { return d1.milliseconds > d2.milliseconds; }
        static public bool operator >=(Duration d1, Duration d2) { return d1.milliseconds >= d2.milliseconds; }

        private Duration(float m)
        {
            milliseconds = m;
        }

        public float GetMilliseconds()
        {
            return milliseconds;
        }

        public long GetWholeMilliseconds()
        {
            return (long)milliseconds;
        }

        public float GetSeconds()
        {
            return milliseconds / MILLISECONDS_PER_SECOND;
        }

        public float GetMinutes()
        {
            return milliseconds / MILLISECONDS_PER_MINUTE;
        }

        public float GetHours()
        {
            return milliseconds / MILLISECONDS_PER_HOUR;
        }

        public float GetDays()
        {
            return milliseconds / MILLISECONDS_PER_DAY;
        }

        public float GetHertz()
        {
            return 1.0f / GetSeconds();
        }

        public float GetLength(DurationUnit unit)
        {
            switch (unit)
            {
                case DurationUnit.Milliseconds: return GetMilliseconds();
                case DurationUnit.Seconds: return GetSeconds();
                case DurationUnit.Minutes: return GetMinutes();
                case DurationUnit.Hours: return GetHours();
                case DurationUnit.Days: return GetDays();

                case DurationUnit.Hertz: return GetHertz();
            }

            throw new UnaccountedBranchException("unit", unit);
        }

        public DurationUnit GetComfortableDurationUnit()
        {
            if (milliseconds <= MILLISECONDS_PER_SECOND * 0.9f)
                return DurationUnit.Hertz;

            if (milliseconds <= MILLISECONDS_PER_SECOND * 1.5f)
                return DurationUnit.Milliseconds;

            if (milliseconds <= MILLISECONDS_PER_MINUTE * 2.5f)
                return DurationUnit.Seconds;

            if (milliseconds <= MILLISECONDS_PER_HOUR * 2.5f)
                return DurationUnit.Minutes;

            if (milliseconds <= MILLISECONDS_PER_DAY * 1.5f)
                return DurationUnit.Hours;

            return DurationUnit.Days;
        }

        public override int GetHashCode()
        {
            return milliseconds.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Duration cast;

            if (obj.Convert<Duration>(out cast))
            {
                if (cast.milliseconds == milliseconds)
                    return true;
            }

            return false;
        }

        public override string ToString()
        {
            return this.ToComfortableString();
        }
    }
}