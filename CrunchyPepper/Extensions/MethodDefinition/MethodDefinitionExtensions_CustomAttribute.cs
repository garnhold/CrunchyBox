﻿using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

using CrunchyDough;

namespace CrunchyPepper
{
    static public class MethodDefinitionExtensions_CustomAttribute
    {
        static public CustomAttribute AddCustomAttributeOfType(this MethodDefinition item, TypeReference type)
        {
            return item.AddCustomAttributeWithConstructor(
                item.GetModuleDefinition().Import(type.Resolve().GetConstructor())
            );
        }

        static public bool CheckAndAddCustomAttributeOfType(this MethodDefinition item, TypeReference type)
        {
            if (item.HasCustomAttributeOfType(type))
                return true;

            item.AddCustomAttributeOfType(type);
            return false;
        }
    }
}