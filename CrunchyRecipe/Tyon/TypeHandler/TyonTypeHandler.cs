using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class TyonTypeHandler : TyonSettingsComponent
    {
        public abstract bool IsCompatible(Type type);

        public abstract TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater);
    }
}
