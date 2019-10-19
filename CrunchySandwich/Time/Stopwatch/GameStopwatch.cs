using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [Serializable]
    public class GameStopwatch : TemporalSeries
    {
        [SerializeField]private TimeType time_type;

        private Stopwatch stopwatch;

        private void Touch()
        {
            stopwatch.SetTimeSource(time_type.GetTimeSource());
        }

        public GameStopwatch(TimeType t)
        {
            time_type = t;

            stopwatch = new Stopwatch(time_type.GetTimeSource());
        }

        public GameStopwatch() : this(TimeType.Active) { }

        public bool Start()
        {
            Touch();

            return stopwatch.Start();
        }

        public bool Pause()
        {
            Touch();

            return stopwatch.Pause();
        }

        public bool IsRunning()
        {
            return stopwatch.IsRunning();
        }

        public void SetTimeType(TimeType t)
        {
            time_type = t;

            Touch();
        }

        public void SetSpeed(float s)
        {
            Touch();

            stopwatch.SetSpeed(s);
        }

        public void SetElapsedTimeInMilliseconds(long m)
        {
            Touch();

            stopwatch.SetElapsedTimeInMilliseconds(m);
        }

        public long GetElapsedTimeInMilliseconds()
        {
            Touch();

            return stopwatch.GetElapsedTimeInMilliseconds();
        }

        public TimeType GetTimeType()
        {
            return time_type;
        }

        public float GetSpeed()
        {
            Touch();

            return stopwatch.GetSpeed();
        }
    }
}