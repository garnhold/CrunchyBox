using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CrunchyDough
{
    static public class AssemblyExtensions_Declared
    {
        static public bool IsTypeDeclaredWithin(this Assembly item, Type type)
        {
            return type.IsDeclaredWithin(item);
        }
    }
}