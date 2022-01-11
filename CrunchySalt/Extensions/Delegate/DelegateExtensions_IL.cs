using System;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class DelegateExtensions_IL
    {
        static public ILMethodInvokation GetILDelegateInvokation(this Delegate item, IEnumerable<ILValue> arguments)
        {
            return item.CreateILLiteral().GetTechnicalInstanceILMethodInvokation("Invoke", arguments);
        }
        static public ILMethodInvokation GetILDelegateInvokation(this Delegate item, params ILValue[] arguments)
        {
            return item.GetILDelegateInvokation((IEnumerable<ILValue>)arguments);
        }
    }
}