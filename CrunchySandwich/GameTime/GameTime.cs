using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [ApplicationEXSatellite]
    static public class GameTimeStepper
    {
        static private void Update()
        {
            GameTime.INSTANCE.Step();
        }
    }

    public class GameTime : TimeSource
    {
        private float delta;
        private float seconds;

        static public readonly GameTime INSTANCE = new GameTime();

        static public float GetDelta()
        {
            return INSTANCE.delta;
        }

        static public float GetTime()
        {
            return INSTANCE.seconds;
        }

        private GameTime()
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