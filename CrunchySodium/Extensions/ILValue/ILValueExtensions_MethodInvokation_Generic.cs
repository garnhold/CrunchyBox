using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sodium
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class ILValueExtensions_MethodInvokation_Generic
    {
        static public ILMethodInvokation GetInstanceILGenericMethodInvokation(this ILValue item, string name, IEnumerable<Type> generic_arguments, IEnumerable<ILValue> arguments)
        {
            return item.GetILGenericMethodInvokation(
                item.GetValueType().GetInstanceMethod(name, arguments.GetValueTypes()),
                generic_arguments,
                arguments
            );
        }

        static public ILMethodInvokation GetILGenericInvoke(this ILValue item, string name, IEnumerable<Type> generic_arguments, IEnumerable<ILValue> arguments)
        {
            return item.GetInstanceILGenericMethodInvokation(name, generic_arguments, arguments);
        }
    }
}