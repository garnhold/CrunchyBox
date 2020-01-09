using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class MethodBuilderExtensions_Compare
    {
        static public bool IsCreated(this MethodBuilder item)
        {
            if (item.GetDeclaringTypeBuilder().IsCreated())
                return true;

            return false;
        }
    }
}