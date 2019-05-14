using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class FieldInfoExtensions_Name
    {
        static public bool IsNamed(this FieldInfo item, string name)
        {
            if (item.Name == name)
                return true;

            return false;
        }

        static public bool IsNamedTheSame(this FieldInfo item, FieldInfo field_info)
        {
            if (item.IsNamed(field_info.Name))
                return true;

            return false;
        }

        static public bool DoesNameContain(this FieldInfo item, string needle)
        {
            if (item.Name.Contains(needle))
                return true;

            return false;
        }

        static public bool DoesNameStartWith(this FieldInfo item, string needle)
        {
            if (item.Name.StartsWith(needle))
                return true;

            return false;
        }
    }
}