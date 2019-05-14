using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CrunchyDough
{
    static public class MethodBaseExtensions_Access
    {
        static public bool IsPrivateMethod(this MethodBase item)
        {
            if (item.IsPrivate)
                return true;

            return false;
        }

        static public bool IsPublicMethod(this MethodBase item)
        {
            if (item.IsPublic)
                return true;

            return false;
        }
    }
}