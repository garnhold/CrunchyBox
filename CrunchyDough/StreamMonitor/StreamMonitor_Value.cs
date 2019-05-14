using System;
using System.IO;

namespace CrunchyDough
{
    public abstract class StreamMonitor_Value<T> : StreamMonitor
    {
        private T last_value;
        private T null_value;

        protected abstract T GetCurrentValue();

        public StreamMonitor_Value(StreamSystemStream s, T n) : base(s)
        {
            null_value = n;
            last_value = null_value;
        }

        public override void Reset()
        {
            last_value = null_value;
        }

        public override bool Update(long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            T current_value = GetCurrentValue();

            if (last_value.NotEqualsEX(current_value))
            {
                last_value = current_value;
                return true;
            }

            return false;
        }
    }
}