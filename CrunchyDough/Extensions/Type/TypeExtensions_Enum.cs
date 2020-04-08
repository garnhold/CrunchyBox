using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Crunchy.Dough
{
    static public class TypeExtensions_Enum
    {
        static public Enum MakeEnumValue(this Type item, long value)
        {
            return (Enum)Enum.ToObject(item, value);
        }
        static public T MakeEnumValue<T>(this Type item, long value)
        {
            return item.MakeEnumValue(value).Convert<T>();
        }

        static public bool IsEnumType(this Type item)
        {
            if (item.IsEnum)
                return true;

            return false;
        }

        static public Type GetEnumUnderlyingType(this Type item)
        {
            return Enum.GetUnderlyingType(item);
        }

        static public bool IsEnumFlagType(this Type item)
        {
            if (item.IsEnumType())
            {
                if (item.HasCustomAttributeOfType<FlagsAttribute>(true))
                    return true;
            }

            return false;
        }

        static public EnumInfo GetEnumInfo(this Type item)
        {
            return EnumInfo.GetEnumInfo(item);
        }

        static public EnumValueInfo GetEnumValueInfoByIndex(this Type item, int index)
        {
            return item.GetEnumInfo().IfNotNull(i => i.GetEnumValueInfoByIndex(index));
        }
        static public Enum GetEnumValueByIndex(this Type item, int index)
        {
            return item.GetEnumValueInfoByIndex(index).IfNotNull(i => i.GetValue());
        }
        static public T GetEnumValueByIndex<T>(this Type item, int index)
        {
            return item.GetEnumValueByIndex(index).Convert<T>();
        }

        static public EnumValueInfo GetEnumValueInfoByName(this Type item, string name)
        {
            return item.GetEnumInfo().IfNotNull(i => i.GetEnumValueInfoByName(name));
        }
        static public Enum GetEnumValueByName(this Type item, string name)
        {
            return item.GetEnumValueInfoByName(name).IfNotNull(i => i.GetValue());
        }
        static public T GetEnumValueByName<T>(this Type item, string name)
        {
            return item.GetEnumValueByName(name).Convert<T>();
        }

        static public EnumValueInfo GetEnumValueInfoByLongValue(this Type item, long value)
        {
            return item.GetEnumInfo().IfNotNull(i => i.GetEnumValueInfoByLongValue(value));
        }
        static public Enum GetEnumValueByLongValue(this Type item, long value)
        {
            return item.GetEnumValueInfoByLongValue(value).IfNotNull(i => i.GetValue());
        }
        static public T GetEnumValueByLongValue<T>(this Type item, long value)
        {
            return item.GetEnumValueByLongValue(value).Convert<T>();
        }

        static public EnumValueInfo GetEnumValueInfoByValue(this Type item, Enum value)
        {
            return item.GetEnumInfo().IfNotNull(i => i.GetEnumValueInfoByValue(value));
        }

        static public IEnumerable<EnumValueInfo> GetEnumValueInfos(this Type item)
        {
            return item.GetEnumInfo().IfNotNull(i => i.GetEnumValueInfos());
        }
        static public IEnumerable<Enum> GetEnumValues(this Type item)
        {
            return item.GetEnumValueInfos().Convert(i => i.GetValue());
        }
        static public IEnumerable<T> GetEnumValues<T>(this Type item)
        {
            return item.GetEnumValues().Convert<Enum, T>();
        }
    }
}