using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class StreamDirectory_Root : StreamDirectory
    {
        private StreamSystem stream_system;

        public StreamDirectory_Root(StreamSystem s) : base("", null)
        {
            stream_system = s;
        }

        public override StreamSystem GetStreamSystem()
        {
            return stream_system;
        }
    }
}