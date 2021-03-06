using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class MethodBaseExtensions_IL
    {
        static public ILValue GetILThis(this MethodBase item)
        {
            return new ILThis(item.DeclaringType);
        }

        static public ILField GetILField(this MethodBase item, FieldInfo field)
        {
            return item.GetILThis().GetILField(field);
        }

        static public ILProp GetILProp(this MethodBase item, PropInfoEX prop)
        {
            return item.GetILThis().GetILProp(prop);
        }
    }
}