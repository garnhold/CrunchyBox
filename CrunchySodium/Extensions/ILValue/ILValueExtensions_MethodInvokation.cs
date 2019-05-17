using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySodium
{
    static public class ILValueExtensions_MethodInvokation
    {
        static public ILMethodInvokation GetInstanceILMethodInvokation(this ILValue item, string name, IEnumerable<ILValue> arguments)
        {
            return item.GetILMethodInvokation(
                item.GetValueType().GetInstanceMethod(name, arguments.GetValueTypes()),
                arguments
            );
        }
        static public ILMethodInvokation GetInstanceILMethodInvokation(this ILValue item, string name, params ILValue[] arguments)
        {
            return item.GetInstanceILMethodInvokation(name, (IEnumerable<ILValue>)arguments);
        }

        static public ILMethodInvokation GetILInvoke(this ILValue item, string name, IEnumerable<ILValue> arguments)
        {
            return item.GetInstanceILMethodInvokation(name, arguments);
        }
        static public ILMethodInvokation GetILInvoke(this ILValue item, string name, params ILValue[] arguments)
        {
            return item.GetILInvoke(name, (IEnumerable<ILValue>)arguments);
        }
    }
}