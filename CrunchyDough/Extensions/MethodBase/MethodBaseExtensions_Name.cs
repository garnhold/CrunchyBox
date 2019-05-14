using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CrunchyDough
{
    static public class MethodBaseExtensions_Name
    {
        static public bool IsNamed(this MethodBase item, string name)
        {
            if (item.Name == name)
                return true;

            return false;
        }

        static public bool IsNamedTheSame(this MethodBase item, MethodBase method_info)
        {
            if (item.IsNamed(method_info.Name))
                return true;

            return false;
        }

        static public bool DoesNameContain(this MethodBase item, string needle)
        {
            if (item.Name.Contains(needle))
                return true;

            return false;
        }

        static public bool DoesNameStartWith(this MethodBase item, string prefix)
        {
            if (item.Name.StartsWith(prefix))
                return true;

            return false;
        }
    }
}