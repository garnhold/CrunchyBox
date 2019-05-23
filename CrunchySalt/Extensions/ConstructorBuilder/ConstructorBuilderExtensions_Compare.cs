using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    static public class ConstructorBuilderExtensions_Compare
    {
        static public bool IsCreated(this ConstructorBuilder item)
        {
            if (item.GetDeclaringTypeBuilder().IsCreated())
                return true;

            return false;
        }
    }
}