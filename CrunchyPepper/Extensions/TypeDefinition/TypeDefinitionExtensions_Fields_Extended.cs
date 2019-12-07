using System;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

namespace Crunchy.Pepper
{
    using Dough;
    
    static public class TypeDefinitionExtensions_Fields_Extended
    {
        static public FieldDefinition CreateField(this TypeDefinition item, TypeReference type, string name, FieldAttributes attributes, IEnumerable<Instruction> instructions = null)
        {
            return item.AddField(new FieldDefinition(name, attributes, type), instructions);
        }
        static public FieldDefinition CreateField(this TypeDefinition item, Type type, string name, FieldAttributes attributes, IEnumerable<Instruction> instructions = null)
        {
            return item.CreateField(type.GetTypeReference(item.GetAssemblyDefinition()), name, attributes, instructions);
        }
        static public FieldDefinition CreateField<T>(this TypeDefinition item, string name, FieldAttributes attributes, IEnumerable<Instruction> instructions = null)
        {
            return item.CreateField(typeof(T), name, attributes, instructions);
        }
    }
}