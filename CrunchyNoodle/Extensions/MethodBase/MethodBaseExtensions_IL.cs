using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class MethodBaseExtensions_IL
    {
        static public ILMethodInvokation GetILInvoke(this MethodBase item, string name, IEnumerable<ILValue> arguments)
        {
            return item.GetILThis().GetILInvoke(name, arguments);
        }
        static public ILMethodInvokation GetILInvoke(this MethodBase item, string name, params ILValue[] arguments)
        {
            return item.GetILInvoke(name, (IEnumerable<ILValue>)arguments);
        }

        static public ILConstructorInvokation GetThisILConstruct(this MethodBase item, IEnumerable<ILValue> arguments)
        {
            return item.GetILThis().GetThisILConstructor(arguments);
        }
        static public ILConstructorInvokation GetThisILConstruct(this MethodBase item, params ILValue[] arguments)
        {
            return item.GetThisILConstruct((IEnumerable<ILValue>)arguments);
        }

        static public ILConstructorInvokation GetBaseILConstruct(this MethodBase item, IEnumerable<ILValue> arguments)
        {
            return item.GetILThis().GetBaseILConstructor(arguments);
        }
        static public ILConstructorInvokation GetBaseILConstruct(this MethodBase item, params ILValue[] arguments)
        {
            return item.GetBaseILConstruct((IEnumerable<ILValue>)arguments);
        }
    }
}