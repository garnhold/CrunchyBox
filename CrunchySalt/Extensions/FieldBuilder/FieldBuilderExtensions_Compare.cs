using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    static public class FieldBuilderExtensions_Compare
    {
        static public bool IsCreated(this FieldBuilder item)
        {
            if (item.GetDeclaringTypeBuilder().IsCreated())
                return true;

            return false;
        }
    }
}