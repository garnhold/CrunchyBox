using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class EnumValueInfo : IDynamicCustomAttributeProvider
    {
        private int index;
        private string name;
        private Enum value;
        private FieldInfo field;

        private EnumInfo enum_info;

        public EnumValueInfo(int i, string n, Enum v, FieldInfo f, EnumInfo ei)
        {
            index = i;
            name = n;
            value = v;
            field = f;

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

        public FieldInfo GetField()
        {
            return field;
        }

        public EnumInfo GetEnumInfo()
        {
            return enum_info;
        }

        public Type GetEnumType()
        {
            return enum_info.GetEnumType();
        }

        public IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return field.GetAllCustomAttributes(inherit);
        }
    }
}