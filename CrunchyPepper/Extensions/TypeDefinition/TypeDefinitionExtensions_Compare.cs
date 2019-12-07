using System;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;

namespace Crunchy.Pepper
{
    using Dough;
    using Salt;
    
    static public class TypeDefinitionExtensions_Compare
    {
        static public bool IsSpecial(this TypeDefinition item)
        {
            if (
                item.IsSpecialName ||
                item.IsRuntimeSpecialName ||
                item.Name.IsStyledAsEntity() == false
            )
            {
                return true;
            }

            return false;
        }
    }
}