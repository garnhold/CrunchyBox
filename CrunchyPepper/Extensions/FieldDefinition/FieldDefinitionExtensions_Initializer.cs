using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

using CrunchyDough;

namespace CrunchyPepper
{
    static public class FieldDefinitionExtensions_Initializer
    {
        static public void AddEmptyInitializer(this FieldDefinition item, IEnumerable<Instruction> instructions)
        {
            if (instructions.IsNotEmpty())
            {
                if (item.IsStatic)
                    item.DeclaringType.GetStaticConstructor().ExtendBeforeFinalReturn(instructions);
                else
                    item.DeclaringType.GetConstructor().ExtendBeforeFinalReturn(instructions);
            }
        }
        static public void AddEmptyInitializer(this FieldDefinition item, params Instruction[] instructions)
        {
            item.AddEmptyInitializer((IEnumerable<Instruction>)instructions);
        }

        static public void AddLoadInitializer(this FieldDefinition item, IEnumerable<Instruction> instructions)
        {
            if (item.IsStatic)
            {
                item.AddEmptyInitializer(
                    instructions
                        .Append(Instruction.Create(OpCodes.Stsfld, item))
                );
            }
            else
            {
                item.AddEmptyInitializer(
                    instructions
                        .Prepend(Instruction.Create(OpCodes.Ldarg_0))
                        .Append(Instruction.Create(OpCodes.Stfld, item))
                );
            }
        }
        static public void AddLoadInitializer(this FieldDefinition item, params Instruction[] instructions)
        {
            item.AddLoadInitializer((IEnumerable<Instruction>)instructions);
        }
    }
}