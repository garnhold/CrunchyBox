using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public abstract class ClassProvider
    {
        protected abstract CmlEntry_Class GetClassInternal(Type type, string layout);

        public CmlEntry_Class GetClass(Type type, string layout)
        {
            return type.GetTypeAndAllBaseTypesAndInterfaces(DetailDirection.SpecificToBasic)
                .Convert(t => GetClassInternal(t, layout))
                .GetFirstNonNull();
        }
    }
}