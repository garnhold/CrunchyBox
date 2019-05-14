using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public class ClassProvider_Attribute : ClassProvider
    {
        protected override CmlEntry_Class GetClassInternal(Type type, string layout)
        {
            return type.GetAllCustomAttributesOfType<CmlClassProviderAttribute>(false)
                .FindFirst(a => a.GetLayout() == layout)
                .IfNotNull(c => c.GetCmlClass(type));
        }
    }
}