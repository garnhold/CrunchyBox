using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class Syncronizer
    {
        static public partial class ILSerialize
        {
            static public ILMethodInvokation GenerateInvokeRead(MethodInfo to_invoke, ILValue caller, ILValue buffer)
            {
                return new ILMethodInvokation(
                    caller,
                    to_invoke,
                    to_invoke.GetEffectiveParameterTypes().Convert(p => ILSerialize.GenerateObjectRead(p, buffer))
                );
            }

            static public ILStatement GenerateInvokeWrite(IEnumerable<ILValue> arguments, ILValue buffer)
            {
                return arguments
                    .Convert(a => ILSerialize.GenerateObjectWrite(a, buffer))
                    .ToBlock();
            }
        }
    }
}