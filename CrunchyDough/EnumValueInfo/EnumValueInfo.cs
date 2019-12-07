using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class EnumValueInfo
    {
        private int index;
        private string name;
        private Enum value;

        private EnumInfo enum_info;

        public EnumValueInfo(int i, string n, Enum v, EnumInfo ei)
        {
            index = i;
            name = n;
            value = v;

            enum_info = ei;
        }

        public int GetIndex()
        {
            return index;
        }

        public string GetName()
        {
            return name;
        }

        public Enum GetValue()
        {
            return value;
        }

        public EnumInfo GetEnumInfo()
        {
            return enum_info;
        }

        public Type GetEnumType()
        {
            return enum_info.GetEnumType();
        }
    }
}