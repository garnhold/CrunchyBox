using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class MethodBuilderExtensions_Foreign
    {
        static public MethodInfo GetNativeMethodInfo(this MethodBuilder item)
        {
            if (item.IsCreated())
            {
                return item.DeclaringType
                    .GetNativeTechnicalMemberMethods()
                    .FindOnly(m => m.MetadataToken == item.GetToken().Token);
            }

            return item;
        }
    }
}