using System;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

using CrunchyDough;

namespace CrunchyPepper
{
    static public class MethodDefinitionExtensions_Surround
    {
        static public void AddSurround(this MethodDefinition item, IEnumerable<Instruction> start, IEnumerable<Instruction> end)
        {
            List<Instruction> instructions = new List<Instruction>();
            List<Instruction> exit_instructions = new List<Instruction>();

            item.Body.Instructions.AlterForTry(item, exit_instructions);

            Instruction first = instructions.AddRangeGetFirst(start);
            Instruction original = instructions.AddRangeGetFirst(item.Body.Instructions);
            Instruction handler = instructions.AddRangeGetFirst(end);

            instructions.Add(OpCodes.Endfinally);
            instructions.AddRange(exit_instructions);

            item.Body.Instructions.Set(instructions);
            item.Body.ExceptionHandlers.Add(new ExceptionHandler(ExceptionHandlerType.Finally) {
                TryStart = original,
                TryEnd = handler,

                HandlerStart = handler,
                HandlerEnd = exit_instructions.GetFirst()
            });
        }
    }
}