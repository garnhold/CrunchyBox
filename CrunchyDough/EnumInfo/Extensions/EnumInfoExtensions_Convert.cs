using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class EnumInfoExtensions_Convert
    {
        static public IEnumerable<EnumValueInfo> ConvertTextToEnumValueInfos(this EnumInfo item, string text)
        {
            if (item.IsFlagType())
                return text.ParseIds().Convert(i => item.GetEnumValueInfoByName(i));

            EnumValueInfo value_info;
            if (item.TryGetEnumValueInfoByName(text, out value_info))
                return value_info.WrapAsEnumerable();

            return Empty.IEnumerable<EnumValueInfo>();
        }

        static public bool TryConvertTextToValue(this EnumInfo item, string text, out Enum value)
        {
            bool did_succeed = true;

            value = item.GetEnumType().MakeEnumValue(
                item.ConvertTextToEnumValueInfos(text)
                    .SkipNotifyNull(() => did_succeed = false)
                    .Convert(i => i.GetLongValue())
                    .BitwiseOR()
            );

            return did_succeed;
        }
        static public Enum ConvertTextToValue(this EnumInfo item, string text)
        {
            Enum value;

            item.TryConvertTextToValue(text, out value);
            return value;
        }

        static public bool TryConvertTextToValue<T>(this EnumInfo item, string text, out T value)
        {
            Enum temp;
            bool to_return = item.TryConvertTextToValue(text, out temp);

            value = temp.Convert<T>();
            return to_return;
        }
        static public T ConvertTextTovalue<T>(this EnumInfo item, string text)
        {
            T value;

            item.TryConvertTextToValue<T>(text, out value);
            return value;
        }
    }
}