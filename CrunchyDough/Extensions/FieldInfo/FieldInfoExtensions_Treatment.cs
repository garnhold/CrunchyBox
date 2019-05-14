using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class FieldInfoExtensions_Treatment
    {
        static public bool CanBeTreatedAs(this FieldInfo item, Type type)
        {
            return item.FieldType.CanBeTreatedAs(type);
        }

        static public bool CanBeTreatedAs<T>(this FieldInfo item)
        {
            return item.CanBeTreatedAs(typeof(T));
        }

        static public bool CanHold(this FieldInfo item, Type type)
        {
            return item.FieldType.CanHold(type);
        }

        static public bool CanHold<T>(this FieldInfo item)
        {
            return item.CanHold(typeof(T));
        }
    }
}