using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
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