using System;
using System.IO;

namespace Crunchy.Dough
{
    public class StreamSource : StreamSystemStream
    {
        private string path;
        private StreamSystem stream_system;

        public StreamSource(string p, StreamSystem ss)
        {
            path = p;
            stream_system = ss;
        }

        public string GetPath()
        {
            return path;
        }

        public StreamSystem GetStreamSystem()
        {
            return stream_system;
        }
    }
}