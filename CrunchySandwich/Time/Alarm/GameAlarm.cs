using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public abstract class GameAlarm : TemporalEvent
    {
        [SerializeField]private GameStopwatch timer;

        private float current_interval;

        protected abstract float CalculateInterval();

        public GameAlarm(TimeType t)
        {
            timer = new GameStopwatch(t);
            Reset();
        }

        public GameAlarm() : this(TimeType.Active) { }

        public bool Start()
        {
            return timer.Start();
        }

        public bool Pause()
        {
            return timer.Pause();
        }

        public void Prime()
        {
            timer.SetElapsedTimeInSeconds(current_interval);
        }

        public void Reset()
        {
            current_interval = CalculateInterval();

            timer.Reset();
        }

        public void SetSpeed(float s)
        {
            timer.SetSpeed(s);
        }

        public bool IsRunning()
        {
            return timer.IsRunning();
        }

        public bool IsTimeOver()
        {
            if (timer.GetElapsedTimeInSeconds() >= current_interval)
                return true;

            return false;
        }

        public float GetSpeed()
        {
            return timer.GetSpeed();
        }
    }
}