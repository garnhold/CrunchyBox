using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class GamepadEvent<T>
    {
        private T value;

        private int frame_counter;
        private Timer inception_timer;
        private Timer duration_timer;

        public GamepadEvent(T v)
        {
            value = v;

            frame_counter = 0;
            inception_timer = new Timer();
            duration_timer = new Timer();
        }

        public GamepadEvent() : this(default(T)) { }

        public void Start()
        {
            inception_timer.Start();
            duration_timer.Start();
        }

        public void Update()
        {
            frame_counter++;
        }

        public void End()
        {
            duration_timer.Pause();
        }

        public T GetValue()
        {
            return value;
        }

        public bool IsOccuringThisFrame()
        {
            if (frame_counter <= 0)
                return true;

            return false;
        }

        public float GetTimeSince()
        {
            return inception_timer.GetElapsedTimeInSeconds();
        }

        public float GetDuration()
        {
            return duration_timer.GetElapsedTimeInSeconds();
        }
    }
}