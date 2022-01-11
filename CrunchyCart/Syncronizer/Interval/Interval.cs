using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class Syncronizer
    {
        public enum Interval
        {
            EveryHour,
            EveryHalfHour,
            EveryQuarterHour,

            EveryTenMinutes,
            EveryFiveMinutes,
            EveryTwoMinutes,
            EveryMinute,

            EveryThirtySeconds,
            EveryTwentySeconds,
            EveryTenSeconds,
            EveryFiveSeconds,
            EveryTwoSeconds,
            EverySecond,

            TwoTimesASecond,
            FiveTimesASecond,
            TenTimesASecond,
            TwentyTimesASecond,
            ThirtyTimesASecond,

            Default
        }
    }
}