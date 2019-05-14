using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class TimeSource_ActiveGameTime : TimeSource
    {
        static public readonly TimeSource_ActiveGameTime INSTANCE = new TimeSource_ActiveGameTime();

        private TimeSource_ActiveGameTime()
        {
        }

        public override long GetCurrentTimeInMilliseconds()
        {
            return ActiveTime.GetActiveTime().GetTimeInMilliseconds();
        }
    }
}