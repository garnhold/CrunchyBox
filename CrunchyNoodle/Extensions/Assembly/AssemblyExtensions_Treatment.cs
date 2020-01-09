using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class AssemblyExtensions_Treatment
    {
        static public bool IsStaticAssembly(this Assembly item)
        {
            try
            {
                if (item.CodeBase.IsVisible())
                    return true;
            }
            catch (Exception)
            {
            }

            return false;
        }

        static public bool IsDynamicAssembly(this Assembly item)
        {
            if (item.IsStaticAssembly() == false)
                return true;

            return false;
        }
    }
}