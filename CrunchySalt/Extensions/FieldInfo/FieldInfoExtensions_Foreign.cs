using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    static public class FieldInfoExtensions_Foreign
    {
        static public FieldInfo GetNativeFieldInfo(this FieldInfo item)
        {
            ForeignFieldInfo foreign_field_info;

            if (item.Convert<ForeignFieldInfo>(out foreign_field_info))
                return foreign_field_info.GetNativeFieldInfo();

            return item;
        }
    }
}