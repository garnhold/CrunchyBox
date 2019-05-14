using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
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