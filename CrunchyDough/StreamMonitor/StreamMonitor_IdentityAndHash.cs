using System;
using System.IO;

namespace CrunchyDough
{
    public class StreamMonitor_IdentityAndHash : StreamMonitor_Combo<StreamMonitor_Identity, StreamMonitor_Value_Hash>
    {
        public StreamMonitor_IdentityAndHash(StreamSystemStream s) : base(s) { }
    }
}