using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ConstructorBuilderExtensions_Foreign
    {
        static public ConstructorInfo GetNativeConstructorInfo(this ConstructorBuilder item)
        {
            if (item.IsCreated())
            {
                return item.DeclaringType
                    .GetNativeInstanceConstructors()
                    .FindOnly(m => m.MetadataToken == item.GetToken().Token);
            }

            return item;
        }
    }
}