using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class TypeExtensions_IL
    {
        static public ILField GetStaticILField(this Type item, string name)
        {
            return item.GetStaticField(name)
                .IfNotNull(f => new ILField(null, f));
        }

        static public ILMethodInvokation GetStaticILMethodInvokation(this Type item, string name, IEnumerable<ILValue> arguments)
        {
            return item.GetStaticMethod(name, arguments.GetValueTypes())
                .IfNotNull(m => new ILMethodInvokation(null, m, arguments));
        }
        static public ILMethodInvokation GetStaticILMethodInvokation(this Type item, string name, params ILValue[] arguments)
        {
            return item.GetStaticILMethodInvokation(name, (IEnumerable<ILValue>)arguments);
        }
    }
}