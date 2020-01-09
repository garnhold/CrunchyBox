using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

namespace Crunchy.Pepper
{
    using Dough;
    
    static public class ICollectionExtensions_Instruction_Try
    {
        static public void AlterForTry(this ICollection<Instruction> item, MethodDefinition method, IList<Instruction> exit_output)
        {
            if (method.HasReturn())
            {
                VariableDefinition store = method.AddVariableOfReturnType();

                exit_output.Set(
                    Instruction.Create(OpCodes.Ldloc, store),
                    Instruction.Create(OpCodes.Ret)
                );

                method.Body.Instructions.Alter(i => i.OpCode == OpCodes.Ret, i => new Instruction[]{
                    i.SetAndGet(OpCodes.Stloc, store),
                    Instruction.Create(OpCodes.Leave, exit_output.GetFirst())
                });
            }
            else
            {
                exit_output.Set(
                    Instruction.Create(OpCodes.Ret)
                );

                method.Body.Instructions.Alter(i => i.OpCode == OpCodes.Ret, i => 
                    i.Set(OpCodes.Leave, exit_output.GetFirst())
                );
            }
        }
    }
}