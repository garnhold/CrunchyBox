using System;
using System.IO;

namespace CrunchyDough
{
    static public class StreamSystemStreamExtensions_Monitor
    {
        static public StreamMonitor CreateIdentityMonitor(this StreamSystemStream item)
        {
            return new StreamMonitor_Identity(item);
        }

        static public StreamMonitor CreateIdentityAndHashMonitor(this StreamSystemStream item)
        {
            return new StreamMonitor_IdentityAndHash(item);
        }

        static public StreamMonitor CreateTimestampMonitor(this StreamSystemStream item)
        {
            return new StreamMonitor_Value_Timestamp(item);
        }

        static public StreamMonitor CreateHashMonitor(this StreamSystemStream item)
        {
            return new StreamMonitor_Value_Hash(item);
        }
    }
}