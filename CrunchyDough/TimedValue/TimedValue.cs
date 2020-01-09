using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class TimedValue<T>
    {
        private T value;
        private Timer timer;

        public TimedValue(T v, long d, TimeSource t)
        {
            value = v;
            timer = new Timer(d, t).StartAndGet();
        }

        public TimedValue(T v, long d) : this(v, d, TimeSource_System.INSTANCE) { }
        public TimedValue(long d) : this(default(T), d) { }

        public TimedValue(T v, Duration d, TimeSource t) : this(v, d.GetWholeMilliseconds(), t) { }
        public TimedValue(T v, Duration d) : this(v, d, TimeSource_System.INSTANCE) { }
        public TimedValue(Duration d) : this(default(T), d) { }

        public void SetValue(T v)
        {
            value = v;
            timer.Restart();
        }

        public T GetValue()
        {
            if (timer.IsTimeUnder())
                return value;

            return default(T);
        }
    }
}