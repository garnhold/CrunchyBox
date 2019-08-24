using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [ApplicationEXSatellite]
    static public class ActualGameTimeStepper
    {
        static private void Update()
        {
            ActualGameTime.INSTANCE.Step();
        }
    }

    public class ActualGameTime : TimeSource
    {
        private float delta;
        private float seconds;

        static public readonly ActualGameTime INSTANCE = new ActualGameTime();

        static public float GetDelta()
        {
            return INSTANCE.delta;
        }

        static public float GetTime()
        {
            return INSTANCE.seconds;
        }

        private ActualGameTime()
        {
            delta = 0.0f;
            seconds = 0.0f;
        }

        public void Step()
        {
            delta = Time.deltaTime;
            seconds += delta;
        }

        public override long GetCurrentTimeInMilliseconds()
        {
            return Duration.Seconds(seconds).GetWholeMilliseconds();
        }
    }
}