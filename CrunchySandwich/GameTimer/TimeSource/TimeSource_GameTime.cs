using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class TimeSource_GameTime : TimeSource
    {
        private long current_time_in_milliseconds;

        static public readonly TimeSource_GameTime INSTANCE = new TimeSource_GameTime();

        private TimeSource_GameTime()
        {
        }

        public override long GetCurrentTimeInMilliseconds()
        {
            if (ApplicationEX.GetInstance().IsUnityMainThread())
            {
                try
                {
                    current_time_in_milliseconds = (long)(Time.time * 1000.0f);
                }
                catch (UnityException)
                {
                }
            }

            return current_time_in_milliseconds;
        }
    }
}