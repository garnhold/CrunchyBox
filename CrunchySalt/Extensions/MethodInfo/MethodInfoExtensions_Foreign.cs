using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class MethodInfoExtensions_Foreign
    {
        static public MethodInfo GetNativeMethodInfo(this MethodInfo item)
        {
            ForeignMethodInfo foreign_method_info;

            if (item.Convert<ForeignMethodInfo>(out foreign_method_info))
                return foreign_method_info.GetNativeMethodInfo();

            return item;
        }
    }
}