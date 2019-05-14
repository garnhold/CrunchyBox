using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class AssemblyNameExtensions_SimpleName
    {
        static public string GetSimpleName(this AssemblyName item)
        {
            return item.Name;
        }
    }
}