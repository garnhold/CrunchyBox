using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class AssemblyBuilderExtensions_DefaultFilename
    {
        static public string GetDefaultFilename(this AssemblyBuilder item)
        {
            return Filename.AddExtension(item.GetSimpleName(), "dll");
        }
    }
}