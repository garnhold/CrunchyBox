using System;

namespace CrunchyDough
{
    public class Timer_Duration : Timer
    {
        private long duration_in_milliseconds;

        public Timer_Duration(long d, TimeSource t) : base(t)
        {
            SetDurationInMilliseconds(d);
        }

        public Timer_Duration(Duration d, TimeSource t) : this(d.GetWholeMilliseconds(), t) { }

        public Timer_Duration(long d) : this(d, TimeSource_Stopwatch.INSTANCE) { }
        public Timer_Duration(Duration d) : this(d, TimeSource_Stopwatch.INSTANCE) { }

        public Timer_Duration(TimeSource t) : this(0, t) { }

        public Timer_Duration() : this(0) { }

        public void Expire()
        {
            if(IsTimeUnder())
                SetElapsedTimeInMilliseconds(duration_in_milliseconds + 1);
        }

        public void SetDurationInMilliseconds(long d)
        {
            duration_in_milliseconds = d;
        }

        public bool IsTimeUnder()
        {
            if (IsTimeOver() == false)
                return true;

            return false;
        }

        public bool IsTimeRunningUnder()
        {
            if (IsTimeUnder() && IsRunning())
                return true;

            return false;
        }

        public bool IsTimeStoppedUnder()
        {
            if (IsTimeUnder() && this.IsStopped())
                return true;

            return false;
        }

        public bool IsTimeOver()
        {
            if (GetTimeLeftInMilliseconds() <= 0)
                return true;

            return false;
        }

        public bool IsTimeRunningOver()
        {
            if (IsTimeOver() && IsRunning())
                return true;

            return false;
        }

        public bool IsTimeStoppedOver()
        {
            if (IsTimeOver() && this.IsStopped())
                return true;

            return false;
        }

        public bool Repeat()
        {
            if (IsTimeOver() || this.IsStopped())
            {
                this.Restart();
                return true;
            }

            return false;
        }

        public bool RepeatIfRunning()
        {
            if (IsRunning())
                return Repeat();

            return false;
        }

        public bool RepeatIfStopped()
        {
            if (this.IsStopped())
                return Repeat();

            return false;
        }

        public long GetDurationInMilliseconds()
        {
            return duration_in_milliseconds;
        }

        public long GetTimeTillInMilliseconds()
        {
            return duration_in_milliseconds - GetElapsedTimeInMilliseconds();
        }

        public long GetTimeLeftInMilliseconds()
        {
            return GetTimeTillInMilliseconds().BindAbove(0);
        }

        public long GetTimeOverInMilliseconds()
        {
            return -GetTimeTillInMilliseconds().BindBelow(0);
        }
    }
}