using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class ConductedValue<T> : TemporalEvent, IDisposable
    {
        private T value;
        private Conductor conductor;

        protected abstract IEnumerable<ConductorOrder> Orders();

        public ConductedValue(T v)
        {
            value = v;
            conductor = new Conductor(Orders);
        }

        public ConductedValue() : this(default(T)) { }

        public void Dispose()
        {
            conductor.Dispose();
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
