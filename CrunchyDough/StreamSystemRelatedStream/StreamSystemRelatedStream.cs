using System;
using System.IO;

namespace CrunchyDough
{
    public abstract class StreamSystemRelatedStream : StreamSystemStream
    {
        private StreamSystemStream stream;

        protected virtual string GetModifiedPath(string input) { return input; }
        protected virtual StreamSystem GetModifiedStreamSystem(StreamSystem input) { return input; }

        public StreamSystemRelatedStream(StreamSystemStream s)
        {
            stream = s;
        }

        public string GetPath()
        {
            return GetModifiedPath(stream.GetPath());
        }

        public StreamSystem GetStreamSystem()
        {
            return GetModifiedStreamSystem(stream.GetStreamSystem());
        }
    }
}