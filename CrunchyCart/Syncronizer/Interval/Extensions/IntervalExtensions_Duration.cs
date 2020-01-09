using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
    static public class IntervalExtensions_Duration
    {
        static public Duration GetDuration(this Syncronizer.Interval item)
        {
            switch(item)
            {
                case Syncronizer.Interval.EveryHour: return Duration.Hours(1.0f);
                case Syncronizer.Interval.EveryHalfHour: return Duration.Hours(0.5f);
                case Syncronizer.Interval.EveryQuarterHour: return Duration.Hours(0.25f);

                case Syncronizer.Interval.EveryTenMinutes: return Duration.Minutes(10.0f);
                case Syncronizer.Interval.EveryFiveMinutes: return Duration.Minutes(5.0f);
                case Syncronizer.Interval.EveryTwoMinutes: return Duration.Minutes(2.0f);
                case Syncronizer.Interval.EveryMinute: return Duration.Minutes(1.0f);

                case Syncronizer.Interval.EveryThirtySeconds: return Duration.Seconds(30.0f);
                case Syncronizer.Interval.EveryTwentySeconds: return Duration.Seconds(20.0f);
                case Syncronizer.Interval.EveryTenSeconds: return Duration.Seconds(10.0f);
                case Syncronizer.Interval.EveryFiveSeconds: return Duration.Seconds(5.0f);
                case Syncronizer.Interval.EveryTwoSeconds: return Duration.Seconds(2.0f);
                case Syncronizer.Interval.EverySecond: return Duration.Seconds(1.0f);

                case Syncronizer.Interval.TwoTimesASecond: return Duration.Hertz(2.0f);
                case Syncronizer.Interval.FiveTimesASecond: return Duration.Hertz(5.0f);
                case Syncronizer.Interval.TenTimesASecond: return Duration.Hertz(10.0f);
                case Syncronizer.Interval.TwentyTimesASecond: return Duration.Hertz(20.0f);
                case Syncronizer.Interval.ThirtyTimesASecond: return Duration.Hertz(30.0f);
            }

            throw new UnaccountedBranchException("item", item);
        }
        static public Duration GetDuration(this Syncronizer.Interval item, Syncronizer.Interval alternative)
        {
            return item.ResolveDefault(alternative).GetDuration();
        }

        static public long GetWholeMilliseconds(this Syncronizer.Interval item)
        {
            return item.GetDuration().GetWholeMilliseconds();
        }
        static public long GetWholeMilliseconds(this Syncronizer.Interval item, Syncronizer.Interval alternative)
        {
            return item.GetDuration(alternative).GetWholeMilliseconds();
        }
    }
}