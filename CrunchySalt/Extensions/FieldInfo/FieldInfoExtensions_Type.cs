using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class FieldInfoExtensions_Type
    {
        static public Type GetILFieldInvokationType(this FieldInfo item)
        {
            if (item.IsInstanceField())
            {
                if (item.DeclaringType.IsStruct())
                    return item.DeclaringType.MakePointerType();

                return item.DeclaringType;
            }

            return typeof(object);
        }
    }
}