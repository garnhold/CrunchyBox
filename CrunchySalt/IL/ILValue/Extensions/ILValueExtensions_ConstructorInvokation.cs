using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ILValueExtensions_ConstructorInvokation
    {
        static public ILConstructorInvokation GetILConstructorInvokation(this ILValue item, ConstructorInfo constructor, IEnumerable<ILValue> arguments)
        {
            return constructor.IfNotNull(c => new ILConstructorInvokation(item, constructor, arguments));
        }
        static public ILConstructorInvokation GetILConstructorInvokation(this ILValue item, ConstructorInfo constructor, params ILValue[] arguments)
        {
            return item.GetILConstructorInvokation(constructor, (IEnumerable<ILValue>)arguments);
        }

        static public ILConstructorInvokation GetThisILConstructor(this ILValue item, IEnumerable<ILValue> arguments)
        {
            return item.GetILConstructorInvokation(
                item.GetValueType().GetInstanceConstructor(arguments.GetValueTypes()),
                arguments
            );
        }
        static public ILConstructorInvokation GetThisILConstructor(this ILValue item, params ILValue[] arguments)
        {
            return item.GetThisILConstructor((IEnumerable<ILValue>)arguments);
        }

        static public ILConstructorInvokation GetBaseILConstructor(this ILValue item, IEnumerable<ILValue> arguments)
        {
            return item.GetILConstructorInvokation(
                item.GetValueType().BaseType.GetInstanceConstructor(arguments.GetValueTypes()),
                arguments
            );
        }
        static public ILConstructorInvokation GetBaseILConstructor(this ILValue item, params ILValue[] arguments)
        {
            return item.GetBaseILConstructor((IEnumerable<ILValue>)arguments);
        }
    }
}