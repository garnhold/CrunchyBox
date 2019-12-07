using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class MethodInfoExtensions_IL
    {
        static public ILMethodInvokation GetStaticILMethodInvokation(this MethodInfo item, IEnumerable<ILValue> arguments)
        {
            return new ILMethodInvokation(null, item, arguments);
        }
        static public ILMethodInvokation GetStaticILMethodInvokation(this MethodInfo item, params ILValue[] arguments)
        {
            return item.GetStaticILMethodInvokation((IEnumerable<ILValue>)arguments);
        }
    }
}