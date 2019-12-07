using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class FieldInfoExtensions_Foreign
    {
        static public FieldInfo GetNativeFieldInfo(this FieldInfo item)
        {
            ForeignFieldInfo foreign_field_info;
            if (item.Convert<ForeignFieldInfo>(out foreign_field_info))
                return foreign_field_info.GetNativeFieldInfo();

            FieldBuilder field_builder;
            if (item.Convert<FieldBuilder>(out field_builder))
                return field_builder.GetNativeFieldInfo();

            return item;
        }
    }
}