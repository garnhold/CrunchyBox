using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class AssemblyExtensions_Visibility
    {
        static public bool IsTypeVisible(this Assembly item, Type type)
        {
            if (type.Assembly == item || item.DoesReferenceAssembly(type.Assembly))
                return true;

            return false;
        }

        static public bool IsAssemblyVisibleToType(this Assembly item, Type type)
        {
            if (item == type.Assembly || item.IsReferencedByAssembly(type.Assembly))
                return true;

            return false;
        }
    }
}