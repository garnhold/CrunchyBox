using System;
using System.IO;

namespace Crunchy.Dough
{
    public class StreamMonitor_Combo<T1, T2> : StreamMonitor
        where T1 : StreamMonitor
        where T2 : StreamMonitor
    {
        private T1 stream_monitor1;
        private T2 stream_monitor2;

        public StreamMonitor_Combo(StreamSystemStream s) : base(s)
        {
            stream_monitor1 = typeof(T1).CreateInstance<T1>(s);
            stream_monitor2 = typeof(T2).CreateInstance<T2>(s);
        }

        public override void Reset()
        {
            stream_monitor1.Reset();
            stream_monitor2.Reset();
        }

        public override bool Update(long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return stream_monitor1.Update(milliseconds) | stream_monitor2.Update(milliseconds);
        }
    }
}