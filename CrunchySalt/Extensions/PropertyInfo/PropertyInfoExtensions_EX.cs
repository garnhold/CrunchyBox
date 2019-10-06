using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    static public class PropertyInfoExtensions_EX
    {
        static public PropertyInfoEX GetPropertyInfoEX(this PropertyInfo item)
        {
            return PropertyInfoEX.GetPropertyInfoEX(item);
        }
    }
}