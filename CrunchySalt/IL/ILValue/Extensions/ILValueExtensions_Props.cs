using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ILValueExtensions_Props
    {
        static public ILProp GetILProp(this ILValue item, PropInfoEX prop)
        {
            return prop.IfNotNull(p => new ILProp(item, p));
        }
    }
}