using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class MethodInfoEXExtensions_Function
    {
        static public Function CreateFunction(this MethodInfoEX item)
        {
            return new Function_MethodInfo(item);
        }
    }
}