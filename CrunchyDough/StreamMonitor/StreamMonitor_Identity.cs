using System;
using System.IO;

namespace CrunchyDough
{
    public class StreamMonitor_Identity : StreamMonitor
    {
        private string last_path;
        private StreamSystem last_stream_system;

        public StreamMonitor_Identity(StreamSystemStream s) : base(s) { }

        public override void Reset()
        {
            last_path = null;
            last_stream_system = null;
        }

        public override bool Update(long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            string current_path = GetStreamSystemStream().GetPath();
            StreamSystem current_stream_system = GetStreamSystemStream().GetStreamSystem();

            if (current_path.NotEqualsEX(last_path) || current_stream_system.NotEqualsEX(last_stream_system))
            {
                last_path = current_path;
                last_stream_system = current_stream_system;

                return true;
            }

            return false;
        }
    }
}