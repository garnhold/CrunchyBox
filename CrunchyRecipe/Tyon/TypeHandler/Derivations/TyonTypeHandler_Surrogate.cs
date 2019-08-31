using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public abstract class TyonTypeHandler_Surrogate : TyonTypeHandler, TyonTypeDehydrater, TyonTypeResolver
    {
        public abstract bool IsTarget(Type type);

        public abstract object CreateSurrogate(Type field_type, object value, TyonDehydrater dehydrater);
        public abstract object ResolveSurrogate(Type type, object surrogate, TyonHydrater hydrater);

        public TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_Surrogate(
                value.GetTypeEX(),
                CreateSurrogate(field_type, value, dehydrater),
                dehydrater
            );
        }

        public bool IsDehydrater(Type type)
        {
            return IsTarget(type);
        }

        public bool IsResolver(Type type)
        {
            return IsTarget(type);
        }
    }
}
