using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class EnumExtensions_Int
    {
        static public int GetInt(this Enum item)
        {
            return Convert.ToInt32(item);
        }
    }
}