using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

namespace Crunchy.Pepper
{
    using Dough;
    
    static public class ICollectionExtensions_Instruction_Add
    {
		static public Instruction Add(this ICollection<Instruction> item, OpCode opcode)
		{
			return item.AddAndGet(Instruction.Create(opcode));
		}

		static public Instruction Add(this ICollection<Instruction> item, OpCode opcode, byte value)
		{
			return item.AddAndGet(Instruction.Create(opcode, value));
		}

		static public Instruction Add(this ICollection<Instruction> item, OpCode opcode, CallSite value)
		{
			return item.AddAndGet(Instruction.Create(opcode, value));
		}

		static public Instruction Add(this ICollection<Instruction> item, OpCode opcode, double value)
		{
			return item.AddAndGet(Instruction.Create(opcode, value));
		}

		static public Instruction Add(this ICollection<Instruction> item, OpCode opcode, FieldReference value)
		{
			return item.AddAndGet(Instruction.Create(opcode, value));
		}

		static public Instruction Add(this ICollection<Instruction> item, OpCode opcode, float value)
		{
			return item.AddAndGet(Instruction.Create(opcode, value));
		}

		static public Instruction Add(this ICollection<Instruction> item, OpCode opcode, Instruction value)
		{
			return item.AddAndGet(Instruction.Create(opcode, value));
		}

		static public Instruction Add(this ICollection<Instruction> item, OpCode opcode, Instruction[] value)
		{
			return item.AddAndGet(Instruction.Create(opcode, value));
		}

		static public Instruction Add(this ICollection<Instruction> item, OpCode opcode, int value)
		{
			return item.AddAndGet(Instruction.Create(opcode, value));
		}

		static public Instruction Add(this ICollection<Instruction> item, OpCode opcode, long value)
		{
			return item.AddAndGet(Instruction.Create(opcode, value));
		}

		static public Instruction Add(this ICollection<Instruction> item, OpCode opcode, MethodReference value)
		{
			return item.AddAndGet(Instruction.Create(opcode, value));
		}

		static public Instruction Add(this ICollection<Instruction> item, OpCode opcode, ParameterDefinition value)
		{
			return item.AddAndGet(Instruction.Create(opcode, value));
		}

		static public Instruction Add(this ICollection<Instruction> item, OpCode opcode, sbyte value)
		{
			return item.AddAndGet(Instruction.Create(opcode, value));
		}

		static public Instruction Add(this ICollection<Instruction> item, OpCode opcode, string value)
		{
			return item.AddAndGet(Instruction.Create(opcode, value));
		}

		static public Instruction Add(this ICollection<Instruction> item, OpCode opcode, TypeReference value)
		{
			return item.AddAndGet(Instruction.Create(opcode, value));
		}

		static public Instruction Add(this ICollection<Instruction> item, OpCode opcode, VariableDefinition value)
		{
			return item.AddAndGet(Instruction.Create(opcode, value));
		}

	}
}
