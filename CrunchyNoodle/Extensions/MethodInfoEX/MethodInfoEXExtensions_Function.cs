using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class MethodInfoEXExtensions_Function
    {
        static public Function CreateFunction(this MethodInfoEX item)
        {
            return new Function_MethodInfo(item);
        }
    }
}