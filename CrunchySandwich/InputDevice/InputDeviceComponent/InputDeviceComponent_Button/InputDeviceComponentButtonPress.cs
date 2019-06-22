using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceComponentButtonPress
    {
        private float time;
        private Timer duration_timer;

        public InputDeviceComponentButtonPress()
        {
            time = Time.time;
            duration_timer = new Timer().StartAndGet();
        }

        public void Release()
        {
            duration_timer.Pause();
        }

        public float GetTime()
        {
            return time;
        }

        public float GetTimeSince()
        {
            return Time.time - time;
        }

        public float GetDuration()
        {
            return duration_timer.GetElapsedTimeInSeconds();
        }
    }
}