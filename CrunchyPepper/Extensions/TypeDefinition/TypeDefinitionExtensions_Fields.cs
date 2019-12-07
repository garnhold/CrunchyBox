using System;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

namespace Crunchy.Pepper
{
    using Dough;
    
    static public class TypeDefinitionExtensions_Fields
    {
        static public FieldDefinition AddField(this TypeDefinition item, FieldDefinition field, IEnumerable<Instruction> instructions = null)
        {
            item.Fields.AddAndGet(field);
            field.AddLoadInitializer(instructions);

            return field;
        }

        static public IEnumerable<FieldDefinition> GetFields(this TypeDefinition item)
        {
            return item.Fields;
        }

        static public FieldDefinition GetFieldByName(this TypeDefinition item, string name)
        {
            return item.GetFields().FindFirst(f => f.Name == name);
        }
    }
}