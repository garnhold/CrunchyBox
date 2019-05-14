using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class EnumExtensions_Flags
    {
        static public bool HasAllOfTheFlags(this Enum item, Enum value)
        {
            return item.GetInt().HasAllBits(value.GetInt());
        }
        static public bool HasTheFlag(this Enum item, Enum value)
        {
            return item.HasAllOfTheFlags(value);
        }

        static public bool HasNoneOfTheFlags(this Enum item, Enum value)
        {
            return item.GetInt().HasNoBits(value.GetInt());
        }
        static public bool DoesNotHaveTheFlag(this Enum item, Enum value)
        {
            return item.HasNoneOfTheFlags(value);
        }

        static public bool HasSomeOfTheFlags(this Enum item, Enum value)
        {
            return item.GetInt().HasAnyBits(value.GetInt());
        }
    }
}