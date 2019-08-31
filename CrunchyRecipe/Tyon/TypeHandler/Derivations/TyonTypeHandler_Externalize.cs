using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public abstract class TyonTypeHandler_Externalize : TyonTypeHandler, TyonTypeDehydrater
    {
        public abstract bool IsDehydrater(Type type);

        public TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_ExternalAddress(dehydrater.RegisterExternalObject(value), dehydrater);
        }
    }
}
