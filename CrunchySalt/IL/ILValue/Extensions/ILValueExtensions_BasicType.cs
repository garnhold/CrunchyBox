using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ILValueExtensions_BasicType
    {
        static public BasicType GetValueBasicType(this ILValue item)
        {
            return item.GetValueType().GetBasicType();
        }
    }
}