using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class MethodInfoEXExtensions_Prop
    {
        static public PropInfoEX CreatePropInfo(this MethodInfoEX item)
        {
            if (item.IsPropSetCompatible())
                return new PropInfoEX_MethodPair(item, null);

            if (item.IsPropGetCompatible())
                return new PropInfoEX_MethodPair(null, item);

            return null;
        }
    }
}