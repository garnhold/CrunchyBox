using System;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;

using CrunchyDough;

namespace CrunchyPepper
{
    static public class TypeDefinitionExtensions_Constructor
    {
        static public MethodDefinition GetConstructor(this TypeDefinition item)
        {
            return item.GetMethods()
                .FindFirst(m => 
                    m.Name == ".ctor" && 
                    m.IsSpecialName == true &&
                    m.IsRuntimeSpecialName == true &&
                    m.Attributes.HasTheFlag(MethodAttributes.Public) &&
                    m.Attributes.DoesNotHaveTheFlag(MethodAttributes.Static)
                )
                ??
                item.AddEmptyMethod(
                    new MethodDefinition(
                        ".ctor",
                        MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName | MethodAttributes.HideBySig,
                        item.GetTypeSystem().Void
                    )
                );
        }

        static public MethodDefinition GetStaticConstructor(this TypeDefinition item)
        {
            return item.GetMethods()
                .FindFirst(m =>
                    m.Name == ".cctor" &&
                    m.IsSpecialName == true &&
                    m.IsRuntimeSpecialName == true &&
                    m.Attributes.HasTheFlag(MethodAttributes.Private) &&
                    m.Attributes.HasTheFlag(MethodAttributes.Static)
                ) 
                ??
                item.AddEmptyMethod(
                    new MethodDefinition(
                        ".cctor",
                        MethodAttributes.Static | MethodAttributes.Private | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName | MethodAttributes.HideBySig,
                        item.GetTypeSystem().Void
                    )
                );
        }
    }
}