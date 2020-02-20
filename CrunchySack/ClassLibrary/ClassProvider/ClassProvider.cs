using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class ClassProvider
    {
        protected abstract CmlClass GetClassInternal(Type type, string layout);

        public CmlClass GetClass(Type type, string layout)
        {
            return type.GetTypeAndAllBaseTypesAndInterfaces(DetailDirection.SpecificToBasic)
                .Convert(t => GetClassInternal(t, layout))
                .GetFirstNonNull();
        }
    }
}