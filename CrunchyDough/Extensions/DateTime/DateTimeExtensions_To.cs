using System;
using System.Reflection;
using System.Globalization;

namespace Crunchy.Dough
{
    static public class DateTimeExtensions_To
    {
        static public string ToRFC3339(this DateTime item)
        {
            return item.ToString("yyyy-MM-dd'T'HH:mm:ss.fffK", DateTimeFormatInfo.InvariantInfo);
        }
    }
}