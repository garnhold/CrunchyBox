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
        static public ILValue GetILConvertEX(this ILValue item, Type type)
        {
            if (item.GetValueType().CanBeTreatedAs(type))
                return item;

            ILMethodInvokation invokation = item.GetValueType()
                .GetConversionInvoker(type)
                .GetILDelegateInvokation(item);

            if (invokation != null)
                return invokation;

            return ILNull.INSTANCE;
        }
    }
}