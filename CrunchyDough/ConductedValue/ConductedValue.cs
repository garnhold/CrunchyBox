using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ConductedValue<T> : TemporalEvent
    {
        private T value;
        private Conductor conductor;

        public ConductedValue(T v)
        {
            value = v;
            conductor = new Conductor();
        }

        public ConductedValue() : this(default(T)) { }

        public void SetOrder(ConductorOrder order)
        {
            conductor.SetOrder(order);
        }

        public bool Start()
        {
            return conductor.Start();
        }

        public bool Pause()
        {
            return conductor.Pause();
        }

        public void Prime()
        {
            conductor.Prime();
        }

        public void Reset()
        {
            conductor.Reset();
        }

        public bool UpdateFulfill()
        {
            return conductor.UpdateFulfill();
        }

        public void SetValue(T v)
        {
            value = v;
        }

        public T GetValue()
        {
            return value;
        }

        public bool IsRunning()
        {
            return conductor.IsRunning();
        }

        public bool IsTimeOver()
        {
            return conductor.IsTimeOver();
        }
    }
}
