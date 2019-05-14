﻿using System;
using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;

namespace CrunchySalt
{
    static public partial class TypeCreator
    {
        static private ModuleBuilder MODULE_BUILDER;
        static private ModuleBuilder GetModuleBuilder()
        {
            if (MODULE_BUILDER == null)
                MODULE_BUILDER = AssemblyCreator.CreateInternalSingleModuleAssemblyBuilder("CrunchySalt.DynamicTypes");

            return MODULE_BUILDER;
        }

        static public TypeBuilder CreateTypeBuilder(string name, TypeAttributes type_attributes)
        {
            return GetModuleBuilder().CreateTypeBuilder(name, type_attributes);
        }

        static public Type CreateType(string name, TypeAttributes type_attributes, Process<TypeBuilder> process)
        {
            return GetModuleBuilder().CreateType(name, type_attributes, process);
        }
    }
}