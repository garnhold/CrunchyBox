using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class BufferedTextWriter
    {
        private string last_text;
        private StreamSystemStream stream_system_stream;

        public BufferedTextWriter(StreamSystemStream s)
        {
            stream_system_stream = s;
        }

        public void WriteText(string text)
        {
            if (text != last_text)
            {
                if (stream_system_stream.WriteText(text).IsDesired())
                    last_text = text;
            }
        }
    }
}