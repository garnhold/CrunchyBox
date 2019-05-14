using System;

namespace CrunchyDough
{
    static public class EnumInfoExtensions
    {
        static public Enum ConvertNameToValue(this EnumInfo item, string name)
        {
            Enum value;

            item.TryConvertNameToValue(name, out value);
            return value;
        }

        static public bool TryConvertNameToValue<T>(this EnumInfo item, string name, out T value)
        {
            Enum object_value;

            if (item.TryConvertNameToValue(name, out object_value))
            {
                value = object_value.Convert<T>();
                return true;
            }

            value = default(T);
            return false;
        }
        static public T ConvertNameToValue<T>(this EnumInfo item, string name)
        {
            T value;

            item.TryConvertNameToValue(name, out value);
            return value;
        }

        static public Enum ConvertTextToValue(this EnumInfo item, string text)
        {
            Enum value;

            item.TryConvertTextToValue(text, out value);
            return value;
        }

        static public bool TryConvertTextToValue<T>(this EnumInfo item, string text, out T value)
        {
            Enum object_value;

            if (item.TryConvertTextToValue(text, out object_value))
            {
                value = object_value.Convert<T>();
                return true;
            }

            value = default(T);
            return false;
        }
        static public T ConvertTextToValue<T>(this EnumInfo item, string text)
        {
            T value;

            item.TryConvertTextToValue<T>(text, out value);
            return value;
        }
    }
}