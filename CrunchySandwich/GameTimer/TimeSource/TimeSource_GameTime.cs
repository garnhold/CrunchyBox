using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class TimeSource_GameTime : TimeSource
    {
        private Timer internal_timer;

        static public readonly TimeSource_GameTime INSTANCE = new TimeSource_GameTime();

        private TimeSource_GameTime()
        {
            internal_timer = new Timer().StartAndGet();
        }

        public override long GetCurrentTimeInMilliseconds()
        {
            return internal_timer.GetElapsedTimeInMilliseconds();
        }
    }
}