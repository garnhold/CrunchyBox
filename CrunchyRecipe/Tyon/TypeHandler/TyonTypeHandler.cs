using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public abstract class TyonTypeHandler : TyonSettingsComponent
    {
        public abstract bool IsCompatible(Type type);

        public abstract TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater);
    }
}
