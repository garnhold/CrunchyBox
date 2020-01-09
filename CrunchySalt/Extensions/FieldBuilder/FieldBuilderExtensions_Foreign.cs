using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class FieldBuilderExtensions_Foreign
    {
        static public FieldInfo GetNativeFieldInfo(this FieldBuilder item)
        {
            if (item.IsCreated())
            {
                return item.DeclaringType
                    .GetNativeMemberFields()
                    .FindOnly(m => m.MetadataToken == item.GetToken().Token);
            }

            return item;
        }
    }
}