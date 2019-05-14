using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class EnumExtensions_Long
    {
        static public long GetLong(this Enum item)
        {
            return Convert.ToInt64(item);
        }
    }
}