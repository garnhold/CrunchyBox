using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public abstract class TyonTypeHandler_Surrogate_ExplicitType<VALUE_TYPE, SURROGATE_TYPE> : TyonTypeHandler_Surrogate
    {
        protected abstract SURROGATE_TYPE CreateSurrogateInternal(VALUE_TYPE value, TyonDehydrater dehydrater);
        protected abstract VALUE_TYPE ResolveSurrogateInternal(SURROGATE_TYPE surrogate, TyonHydrater hydrater);

        public override object CreateSurrogate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return CreateSurrogateInternal(value.ConvertEX<VALUE_TYPE>(), dehydrater);
        }

        public override object ResolveSurrogate(Type type, object surrogate, TyonHydrater hydrater)
        {
            return ResolveSurrogateInternal(surrogate.ConvertEX<SURROGATE_TYPE>(), hydrater);
        }

        public override bool IsTarget(Type type)
        {
            if (type.CanBeTreatedAs<VALUE_TYPE>())
                return true;

            return false;
        }
    }
}
