using System;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

namespace Crunchy.Pepper
{
    using Dough;
    
    static public class TypeDefinitionExtensions_Methods
    {
        static public MethodDefinition AddMethod(this TypeDefinition item, MethodDefinition method, IEnumerable<Instruction> instructions)
        {
            item.Methods.Add(method);

            method.Body.Instructions.Set(instructions);
            return method;
        }

        static public MethodDefinition AddEmptyMethod(this TypeDefinition item, MethodDefinition method)
        {
            return item.AddMethod(method, new Instruction[]{
                Instruction.Create(OpCodes.Ret)
            });
        }

        static public IEnumerable<MethodDefinition> GetMethods(this TypeDefinition item)
        {
            return item.Methods;
        }
    }
}