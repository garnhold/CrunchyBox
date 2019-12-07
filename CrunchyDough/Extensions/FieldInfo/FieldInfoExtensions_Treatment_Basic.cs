using System;
using System.Reflection;

namespace Crunchy.Dough
{
    static public class FieldInfoExtensions_Treatment_Basic
    {
        static public bool IsTypicalReferenceType(this FieldInfo item)
        {
            return item.FieldType.IsTypicalReferenceType();
        }

        static public bool IsTypicalValueType(this FieldInfo item)
        {
            return item.FieldType.IsTypicalValueType();
        }
    }
}