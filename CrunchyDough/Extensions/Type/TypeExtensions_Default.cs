using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CrunchyDough
{
    static public class TypeExtensions_Default
    {
        static public object GetDefaultValue(this Type item)
        {
            if(item.IsReferenceType())
                return null;

            return item.CreateInstance();
        }
    }
}