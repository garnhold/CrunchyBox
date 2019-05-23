using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class EnumExtensions_Long
    {
        static public long GetLongValue(this Enum item)
        {
            return Convert.ToInt64(item);
        }
    }
}