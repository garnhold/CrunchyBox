using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

namespace Crunchy.Pepper
{
    using Dough;
    
    static public class MethodDefinitionExtensions_Extend
    {
        static public void ExtendBeforeFinalReturn(this MethodDefinition item, IEnumerable<Instruction> instructions)
        {
            Instruction final_instruction = item.Body.Instructions.PopLast();

            if(final_instruction.OpCode == OpCodes.Ret)
            {
                item.Body.Instructions.AddRange(instructions);
                item.Body.Instructions.Add(final_instruction);
            }
        }
        static public void ExtendBeforeFinalReturn(this MethodDefinition item, params Instruction[] instructions)
        {
            item.ExtendBeforeFinalReturn((IEnumerable<Instruction>)instructions);
        }
    }
}