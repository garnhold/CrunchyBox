using System;
using System.IO;

namespace Crunchy.Dough
{
    public abstract class StreamMonitor
    {
        private StreamSystemStream stream_system_stream;

        public abstract void Reset();
        public abstract bool Update(long milliseconds = StreamSystem.DEFAULT_WAIT);

        public StreamMonitor(StreamSystemStream s)
        {
            stream_system_stream = s;
        }

        public StreamSystemStream GetStreamSystemStream()
        {
            return stream_system_stream;
        }
    }
}