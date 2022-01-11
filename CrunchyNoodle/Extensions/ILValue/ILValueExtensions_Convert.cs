using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class ILValueExtensions_Convert
    {
        static public ILMethodInvokation GetILConvertEX(this ILValue item, Type type)
        {
            return item.GetValueType()
                .GetConversionInvoker(type)
                .GetILDelegateInvokation(item);
        }
    }
}