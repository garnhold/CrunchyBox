using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

namespace Crunchy.Pepper
{
    using Dough;
    
    static public class MethodDefinitionExtensions_Clear
    {
        static public void ClearBody(this MethodDefinition item)
        {
            item.Body.Instructions.Set(Instruction.Create(OpCodes.Ret));
        }
    }
}