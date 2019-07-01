﻿using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    static public class TypeExtensions_Initilization
    {
        static public void PrepareForDynamicUse(this Type item)
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(item.TypeHandle);
        }
    }
}