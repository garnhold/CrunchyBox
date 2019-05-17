using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    static public class ILValueExtensions_MethodInvokation
    {
        static public ILMethodInvokation GetILMethodInvokation(this ILValue item, MethodInfo method, IEnumerable<ILValue> arguments)
        {
            return method.IfNotNull(m => new ILMethodInvokation(item, method, arguments));
        }
        static public ILMethodInvokation GetILMethodInvokation(this ILValue item, MethodInfo method, params ILValue[] arguments)
        {
            return item.GetILMethodInvokation(method, (IEnumerable<ILValue>)arguments);
        }

        static public ILMethodInvokation GetTechnicalInstanceILMethodInvokation(this ILValue item, string name, IEnumerable<ILValue> arguments)
        {
            return item.GetILMethodInvokation(
                item.GetValueType().GetTechnicalInstanceMethod(name, arguments.GetValueTypes()),
                arguments
            );
        }
        static public ILMethodInvokation GetTechnicalInstanceILMethodInvokation(this ILValue item, string name, params ILValue[] arguments)
        {
            return item.GetTechnicalInstanceILMethodInvokation(name, (IEnumerable<ILValue>)arguments);
        }
    }
}