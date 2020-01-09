using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Crunchy.Dough
{
    static public class TypeExtensions_Filename
    {
        static public string GetTypeAssemblyFilename(this Type item)
        {
            return item.Assembly.GetAssemblyFilename();
        }

        static public string GetTypeAssemblyDirectory(this Type item)
        {
            return item.Assembly.GetAssemblyDirectory();
        }
    }
}