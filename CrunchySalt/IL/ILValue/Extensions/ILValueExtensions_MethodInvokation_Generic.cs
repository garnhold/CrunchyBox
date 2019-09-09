using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    static public class ILValueExtensions_MethodInvokation_Generic
    {
        static public ILMethodInvokation GetILGenericMethodInvokation(this ILValue item, MethodInfo method, IEnumerable<Type> generic_arguments, IEnumerable<ILValue> arguments)
        {
            return item.GetILMethodInvokation(
                method.MakeGenericMethod(generic_arguments.ToArray()),
                arguments
            );
        }

        static public ILMethodInvokation GetTechnicalInstanceILGenericMethodInvokation(this ILValue item, string name, IEnumerable<Type> generic_arguments, IEnumerable<ILValue> arguments)
        {
            return item.GetILGenericMethodInvokation(
                item.GetValueType().GetTechnicalInstanceMethod(name, arguments.GetValueTypes()),
                generic_arguments,
                arguments
            );
        }
    }
}