using System;

namespace Crunchy.Bun
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class Easer : TemporalDuration
    {
        private EaseOperation operation;
        private TemporalDuration timer;

        public Easer(EaseOperation o, TemporalDuration t)
        {
            operation = o;
            timer = t;
        }

        public bool Start()
        {
            return timer.Start();
        }

        public bool Pause()
        {
            return timer.Pause();
        }

        public void SetSpeed(float speed)
        {
            timer.SetSpeed(speed);
        }

        public void SetDurationInMilliseconds(long d)
        {
            timer.SetDurationInMilliseconds(d);
        }

        public void SetElapsedTimeInMilliseconds(long m)
        {
            timer.SetElapsedTimeInMilliseconds(m);
        }

        public bool IsRunning()
        {
            return timer.IsRunning();
        }

        public float GetSpeed()
        {
            return timer.GetSpeed();
        }

        public long GetDurationInMilliseconds()
        {
            return timer.GetDurationInMilliseconds();
        }

        public long GetElapsedTimeInMilliseconds()
        {
            return timer.GetElapsedTimeInMilliseconds();
        }

        public float GetCurrentValue()
        {
            return operation(timer.GetTimeElapsedInPercent());
        }
    }
}