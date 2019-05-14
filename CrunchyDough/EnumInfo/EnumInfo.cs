using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class EnumInfo
    {
        private Type enum_type;
        private bool is_flag_type;

        private OptionTable<Enum> strings_to_values;

        private Dictionary<Enum, int> values_to_indexs;
        private Dictionary<int, Enum> indexs_to_values;

        static public IEnumerable<T> GetValues<T>()
        {
            return typeof(T).GetEnumInfo().GetValues().Convert<Enum, T>();
        }

        static private OperationCache<EnumInfo, Type> GET_ENUM_INFO = ReflectionCache.Get().NewOperationCache(delegate(Type type) {
            if (type.CanBeTreatedAs<Enum>())
                return new EnumInfo(type);

            return null;
        });
        static public EnumInfo GetEnumInfo(Type type)
        {
            return GET_ENUM_INFO.Fetch(type);
        }

        private EnumInfo(Type e)
        {
            enum_type = e;
            is_flag_type = enum_type.IsEnumFlagType();

            strings_to_values = new OptionTable<Enum>(
                Enum.GetNames(e).PairStrict(Enum.GetValues(e).Bridge<Enum>())
                    .ConvertToKeyValuePairs()
            );

            values_to_indexs = Enum.GetValues(e).Bridge<Enum>().ConvertToKeyOfIndexedPair().ToDictionaryOverwrite();
            indexs_to_values = Enum.GetValues(e).Bridge<Enum>().ConvertToValueOfIndexedPair().ToDictionaryOverwrite();
        }

        public Type GetEnumType()
        {
            return enum_type;
        }

        public bool TryConvertIndexToValue(int index, out Enum value)
        {
            return indexs_to_values.TryGetValue(index, out value);
        }
        public bool TryConvertValueToIndex(Enum value, out int index)
        {
            return values_to_indexs.TryGetValue(value, out index);
        }

        public bool TryConvertNameToValue(string name, out Enum value)
        {
            return strings_to_values.TryLookup(out value, name);
        }

        public bool TryConvertTextToValue(string text, out Enum value)
        {
            value = null;

            if (IsFlagType())
            {
                value = (Enum)Enum.ToObject(
                    enum_type,
                    text.ParseIds().Convert(i => this.ConvertNameToValue(i).GetLong()).BitwiseOR()
                );

                return true;
            }

            return TryConvertNameToValue(text, out value);
        }

        public bool IsFlagType()
        {
            return is_flag_type;
        }

        public IEnumerable<Enum> GetValues()
        {
            return indexs_to_values.Values;
        }
    }
}