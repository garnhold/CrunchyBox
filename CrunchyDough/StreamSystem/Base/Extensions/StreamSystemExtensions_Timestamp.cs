using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StreamSystemExtensions_Timestamp
    {
        static public TimeSpan GetStreamAge(this StreamSystem item, string path)
        {
            return item.GetStreamTimestamp(path).GetAgeFromDate();
        }
    }
}