using System;
using System.Reflection;

namespace Crunchy.Dough
{
    static public class FieldInfoExtensions_Generic
    {
        static public bool IsGenericTypelessField(this FieldInfo item)
        {
            if (item.FieldType.IsGenericParameter)
                return true;

            return false;
        }

        static public bool IsGenericTypedField(this FieldInfo item)
        {
            if (item.Module.ResolveField(item.MetadataToken).FieldType != item.FieldType)
                return true;

            return false;
        }

        static public bool IsGenericField(this FieldInfo item)
        {
            if (item.IsGenericTypelessField() || item.IsGenericTypedField())
                return true;

            return false;
        }
    }
}