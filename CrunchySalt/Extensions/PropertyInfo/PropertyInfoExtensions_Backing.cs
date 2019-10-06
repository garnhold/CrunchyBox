using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    static public class PropertyInfoExtensions_Backing
    {
        static public FieldInfo GetBackingField(this PropertyInfo item)
        {
            return item.DeclaringType.GetMemberField(item.Name.StyleAsVariableName());
        }
    }
}