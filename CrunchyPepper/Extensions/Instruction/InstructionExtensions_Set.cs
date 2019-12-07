using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

namespace Crunchy.Pepper
{
    using Dough;
    
    static public class InstructionExtensions_Set
    {
        static public void Set(this Instruction item, OpCode opcode, object operand)
        {
            item.OpCode = opcode;
            item.Operand = operand;
        }

        static public Instruction SetAndGet(this Instruction item, OpCode opcode, object operand)
        {
            item.Set(opcode, operand);
            return item;
        }
    }
}