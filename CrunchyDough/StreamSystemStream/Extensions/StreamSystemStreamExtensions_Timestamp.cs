using System;
using System.IO;

namespace CrunchyDough
{
    static public class StreamSystemStreamExtensions_Timestamp
    {
        static public DateTime GetTimestamp(this StreamSystemStream item)
        {
            return item.GetStreamSystem().GetStreamTimestamp(item.GetPath());
        }
    }
}