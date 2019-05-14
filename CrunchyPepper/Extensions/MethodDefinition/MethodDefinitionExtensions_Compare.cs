using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyPepper
{
    static public class MethodDefinitionExtensions_Compare
    {
        static public bool HasReturn(this MethodDefinition item)
        {
            if (item.ReturnType.IsVoidType() == false)
                return true;

            return false;
        }

        static public bool IsSpecial(this MethodDefinition item)
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