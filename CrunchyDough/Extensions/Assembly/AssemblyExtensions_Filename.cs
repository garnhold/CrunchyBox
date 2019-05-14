using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CrunchyDough
{
    static public class AssemblyExtensions_Filename
    {
        static public string GetAssemblyFilename(this Assembly item)
        {
            return Filename.GetAbsolutePath(new Uri(item.CodeBase).LocalPath);
        }

        static public string GetAssemblyDirectory(this Assembly item)
        {
            return Filename.GetDirectory(item.GetAssemblyFilename());
        }
    }
}