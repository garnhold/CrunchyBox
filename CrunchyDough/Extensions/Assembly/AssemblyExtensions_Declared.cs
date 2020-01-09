using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Crunchy.Dough
{
    static public class AssemblyExtensions_Declared
    {
        static public bool IsTypeDeclaredWithin(this Assembly item, Type type)
        {
            return type.IsDeclaredWithin(item);
        }
    }
}