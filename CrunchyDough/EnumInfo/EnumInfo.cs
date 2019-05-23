using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class EnumInfo
    {
        private Type enum_type;
        private Type underlying_type;
        private bool is_flag_type;

        private List<EnumValueInfo> enum_value_infos;

        private Dictionary<string, EnumValueInfo> enum_value_infos_by_name;
        private Dictionary<Enum, EnumValueInfo> enum_value_infos_by_value;
        private Dictionary<long, EnumValueInfo> enum_value_infos_by_long_value;

        private EnumValueInfo min_enum_value_info;
        private EnumValueInfo max_enum_value_info;

        private int minimum_bitage;

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
            underlying_type = enum_type.GetEnumUnderlyingType();
            is_flag_type = enum_type.IsEnumFlagType();

            enum_value_infos = Enum.GetNames(enum_type)
                .PairStrictWithIndex(Enum.GetValues(enum_type).Bridge<Enum>(), (i, n, v) => new EnumValueInfo(i, n, v, this))
                .ToList();

            enum_value_infos_by_name = enum_value_infos.ConvertToValueOfPair(i => i.GetName()).ToDictionaryOverwrite();
            enum_value_infos_by_value = enum_value_infos.ConvertToValueOfPair(i => i.GetValue()).ToDictionaryOverwrite();
            enum_value_infos_by_long_value = enum_value_infos.ConvertToValueOfPair(i => i.GetLongValue()).ToDictionaryOverwrite();

            min_enum_value_info = enum_value_infos.FindLowestRated(i => i.GetLongValue());
            max_enum_value_info = enum_value_infos.FindHighestRated(i => i.GetLongValue());

            minimum_bitage = max_enum_value_info.GetLongValue().GetHighestBitIndex() + 1;
        }

        public bool TryGetEnumValueInfoByIndex(int index, out EnumValueInfo info)
        {
            return enum_value_infos.TryGet(index, out info);
        }

        public bool TryGetEnumValueInfoByName(string name, out EnumValueInfo info)
        {
            return enum_value_infos_by_name.TryGetValue(name, out info);
        }

        public bool TryGeEnumValuetInfoByValue(Enum value, out EnumValueInfo info)
        {
            return enum_value_infos_by_value.TryGetValue(value, out info);
        }

        public bool TryGetEnumValueInfoByLongValue(long value, out EnumValueInfo info)
        {
            return enum_value_infos_by_long_value.TryGetValue(value, out info);
        }

        public Type GetEnumType()
        {
            return enum_type;
        }

        public Type GetUnderlyingType()
        {
            return underlying_type;
        }

        public bool IsFlagType()
        {
            return is_flag_type;
        }

        public IEnumerable<EnumValueInfo> GetEnumValueInfos()
        {
            return enum_value_infos;
        }

        public EnumValueInfo GetMinEnumValueInfo()
        {
            return min_enum_value_info;
        }

        public EnumValueInfo GetMaxEnumValueInfo()
        {
            return max_enum_value_info;
        }

        public int GetMinimumBitage()
        {
            return minimum_bitage;
        }
    }
}