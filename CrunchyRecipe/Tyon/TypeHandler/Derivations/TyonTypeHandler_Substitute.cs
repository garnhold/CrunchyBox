using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public abstract class TyonTypeHandler_Substitute : TyonTypeHandler
    {
        protected abstract object Substitute(object value);

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return dehydrater.CreateTyonValue(field_type, Substitute(value));
        }
    }
}
