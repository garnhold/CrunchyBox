using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemStreamExtensions_Timestamp
    {
        static public DateTime GetTimestamp(this StreamSystemStream item)
        {
            return item.GetStreamSystem().GetStreamTimestamp(item.GetPath());
        }
    }
}