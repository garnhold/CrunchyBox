using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

namespace Crunchy.Pepper
{
    using Dough;
    
    static public class MethodDefinitionExtensions_Variables
    {
        static public VariableDefinition AddVariable(this MethodDefinition item, VariableDefinition variable)
        {
            item.Body.Variables.Add(variable);

            return variable;
        }

        static public VariableDefinition AddVariableOfReturnType(this MethodDefinition item)
        {
            return item.AddVariable(new VariableDefinition(item.ReturnType));
        }
    }
}