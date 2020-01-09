using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ConstructorInfoExtensions_Foreign
    {
        static public ConstructorInfo GetNativeConstructorInfo(this ConstructorInfo item)
        {
            ForeignConstructorInfo foreign_constructor_info;

            if (item.Convert<ForeignConstructorInfo>(out foreign_constructor_info))
                return foreign_constructor_info.GetNativeConstructorInfo();

            return item;
        }
    }
}