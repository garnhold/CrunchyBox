using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyBroth
{
    static public class MethodInfoExtensions_Pointer
    {
        static public IntPtr GetFunctionPointerEX(this MethodInfo item)
        {
            RuntimeHelpers.PrepareMethod(item.MethodHandle);

            return item.MethodHandle.GetFunctionPointer();
        }
    }
}