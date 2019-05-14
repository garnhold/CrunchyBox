using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class FieldInfoExtensions_Compare
    {
        static public bool IsStaticField(this FieldInfo item)
        {
            if (item.IsStatic)
                return true;

            return false;
        }

        static public bool IsInstanceField(this FieldInfo item)
        {
            if (item.IsStaticField() == false)
                return true;

            return false;
        }

        static public bool IsPublicField(this FieldInfo item)
        {
            if (item.IsPublic)
                return true;

            return false;
        }

        static public bool IsPrivateField(this FieldInfo item)
        {
            if (item.IsPrivate)
                return true;

            return false;
        }
    }
}