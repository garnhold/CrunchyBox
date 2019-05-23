using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    static public class ConstructorBuilderExtensions_TypeBuilder
    {
        static public TypeBuilder GetDeclaringTypeBuilder(this ConstructorBuilder item)
        {
            return item.DeclaringType.Convert<TypeBuilder>();
        }
    }
}