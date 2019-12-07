using System;
using System.Reflection;

namespace Crunchy.Dough
{
    public class TemporalEvent_Duration : TemporalEvent
    {
        private TemporalDuration temporal_duration;

        public TemporalEvent_Duration(TemporalDuration d)
        {
            temporal_duration = d;
        }

        public bool Start()
        {
            return temporal_duration.Start();
        }

        public bool Pause()
        {
            return temporal_duration.Pause();
        }

        public void Reset()
        {
            temporal_duration.Reset();
        }

        public void Prime()
        {
            temporal_duration.Expire();
        }

        public bool IsRunning()
        {
            return temporal_duration.IsRunning();
        }

        public bool IsTimeOver()
        {
            return temporal_duration.IsTimeOver();
        }

        public void SetSpeed(float speed)
        {
            temporal_duration.SetSpeed(speed);
        }

        public float GetSpeed()
        {
            return temporal_duration.GetSpeed();
        }
    }
}