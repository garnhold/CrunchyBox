using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class PropertyInfoExtensions_Prop
    {
        static public PropInfoEX GetProp(this PropertyInfo item)
        {
            return new PropInfoEX_Property(item.GetPropertyInfoEX());
        }

        static public PropInfoEX GetPermissiveProp(this PropertyInfo item)
        {
            return new PropInfoEX_PermissiveProperty(item.GetPropertyInfoEX());
        }
    }
}