using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    static public class FieldBuilderExtensions_TypeBuilder
    {
        static public TypeBuilder GetDeclaringTypeBuilder(this FieldBuilder item)
        {
            return item.DeclaringType.Convert<TypeBuilder>();
        }
    }
}