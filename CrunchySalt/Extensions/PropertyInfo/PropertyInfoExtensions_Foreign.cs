using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class PropertyInfoExtensions_Foreign
    {
        static public PropertyInfo GetNativePropertyInfo(this PropertyInfo item)
        {
            ForeignPropertyInfo foreign_property_info;

            if (item.Convert<ForeignPropertyInfo>(out foreign_property_info))
                return foreign_property_info.GetNativePropertyInfo();

            return item;
        }
    }
}