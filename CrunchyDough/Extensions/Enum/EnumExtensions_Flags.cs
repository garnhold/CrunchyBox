using System;
using System.Reflection;

namespace Crunchy.Dough
{
    static public class EnumExtensions_Flags
    {
        static public bool HasAllOfTheFlags(this Enum item, Enum value)
        {
            return item.GetLongValue().HasAllBits(value.GetLongValue());
        }
        static public bool HasTheFlag(this Enum item, Enum value)
        {
            return item.HasAllOfTheFlags(value);
        }

        static public bool HasNoneOfTheFlags(this Enum item, Enum value)
        {
            return item.GetLongValue().HasNoBits(value.GetLongValue());
        }
        static public bool DoesNotHaveTheFlag(this Enum item, Enum value)
        {
            return item.HasNoneOfTheFlags(value);
        }

        static public bool HasSomeOfTheFlags(this Enum item, Enum value)
        {
            return item.GetLongValue().HasAnyBits(value.GetLongValue());
        }
    }
}