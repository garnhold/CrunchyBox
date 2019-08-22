using System;

namespace CrunchyDough
{
    public class Trigger_Periodic_Regular : Trigger_Periodic
    {
        [SettingField]private long interval_in_milliseconds;

        protected override long CalculateIntervalInMilliseconds()
        {
            return interval_in_milliseconds;
        }

        public Trigger_Periodic_Regular(long i, TimeSource t) : base(t)
        {
            interval_in_milliseconds = i;
        }

        public Trigger_Periodic_Regular(long i) : this(i, TimeSource_Stopwatch.INSTANCE) { }
    }
}