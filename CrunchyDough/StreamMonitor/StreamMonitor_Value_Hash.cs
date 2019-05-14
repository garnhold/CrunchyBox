using System;
using System.IO;

namespace CrunchyDough
{
    public class StreamMonitor_Value_Hash : StreamMonitor_Value<ByteSequence>
    {
        protected override ByteSequence GetCurrentValue()
        {
 	        return GetStreamSystemStream().GetHash();
        }

        public StreamMonitor_Value_Hash(StreamSystemStream s) : base(s, null) { }
    }
}