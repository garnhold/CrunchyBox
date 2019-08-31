using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonTypeHandler_Surrogate_Default : TyonTypeHandler_Surrogate
    {
        static public readonly TyonTypeHandler_Surrogate_Default INSTANCE = new TyonTypeHandler_Surrogate_Default();

        private TyonTypeHandler_Surrogate_Default() { }

        public override object CreateSurrogate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return value.ToStringEX();
        }

        public override object ResolveSurrogate(Type type, object surrogate, TyonHydrater hydrater)
        {
            return surrogate.ConvertEX(type);
        }

        public override bool IsTarget(Type type)
        {
            return true;
        }
    }
}
