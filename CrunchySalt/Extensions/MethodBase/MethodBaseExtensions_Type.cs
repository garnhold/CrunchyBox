using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class MethodBaseExtensions_Type
    {
        static public Type GetILMethodInvokationType(this MethodBase item)
        {
            if (item.IsEffectivelyInstanceMethod())
            {
                if (item.IsTechnicallyInstanceMethod() && item.DeclaringType.IsStruct())
                    return item.DeclaringType.MakePointerType();

                return item.GetMethodEffectiveType();
            }

            return typeof(object);
        }
    }
}