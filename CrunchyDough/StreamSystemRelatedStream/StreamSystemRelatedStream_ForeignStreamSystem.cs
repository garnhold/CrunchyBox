using System;
using System.IO;

namespace Crunchy.Dough
{
    public class StreamSystemRelatedStream_ForeignStreamSystem : StreamSystemRelatedStream
    {
        private StreamSystem foreign_stream_system;

        protected override StreamSystem GetModifiedStreamSystem(StreamSystem input)
        {
            return foreign_stream_system;
        }

        public StreamSystemRelatedStream_ForeignStreamSystem(StreamSystemStream s, StreamSystem ss) : base(s)
        {
            foreign_stream_system = ss;
        }
    }
}