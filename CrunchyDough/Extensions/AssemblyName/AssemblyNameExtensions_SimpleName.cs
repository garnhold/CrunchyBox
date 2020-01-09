using System;
using System.Reflection;

namespace Crunchy.Dough
{
    static public class AssemblyNameExtensions_SimpleName
    {
        static public string GetSimpleName(this AssemblyName item)
        {
            return item.Name;
        }
    }
}