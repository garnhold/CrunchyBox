using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [ApplicationEXSatellite]
    static public class ActiveGameTimeStepper
    {
        static private void Update()
        {
            ActiveGameTime.INSTANCE.Step();
        }
    }

    public class ActiveGameTime : TimeSource
    {
        private float delta;
        private float seconds;

        private bool is_paused;
        private float multiplier;
        private float target_multiplier;
        private float multiplier_speed;

        static public readonly ActiveGameTime INSTANCE = new ActiveGameTime();

        static public void Pause()
        {
            INSTANCE.is_paused = true;
        }

        static public void Unpause()
        {
            INSTANCE.is_paused = false;
        }

        static public void SetMultiplier(float m)
        {
            INSTANCE.multiplier = m;
            INSTANCE.target_multiplier = m;
        }

        static public void SetMultiplier(float m, float s)
        {
            INSTANCE.target_multiplier = m;
            INSTANCE.multiplier_speed = s;
        }

        static public float GetDelta()
        {
            return INSTANCE.delta;
        }

        static public float GetTime()
        {
            return INSTANCE.seconds;
        }

        static public float GetMultiplier()
        {
            return INSTANCE.multiplier;
        }

        private ActiveGameTime()
        {
            delta = 0.0f;
            seconds = 0.0f;

            is_paused = false;
            multiplier = 1.0f;
            target_multiplier = 1.0f;
            multiplier_speed = 6.0f;
        }

        public void Step()
        {
            if (is_paused)
                delta = 0.0f;
            else
            {
                delta = Time.deltaTime * multiplier;
                seconds += delta;
            }

            multiplier = multiplier.GetInterpolate(target_multiplier, multiplier_speed * Time.deltaTime);
        }

        public override long GetCurrentTimeInMilliseconds()
        {
            return Duration.Seconds(seconds).GetWholeMilliseconds();
        }
    }
}