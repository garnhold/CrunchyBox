using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public abstract class TyonBridge_CalculateExternal : TyonBridge
    {
        protected abstract object CalculateAddress(object value, Variable variable, TyonContext_Dehydration context);
        protected abstract object ResolveAddress(object address, Variable variable, TyonContext_Hydration context);

        public override TyonValue CreateTyonValue(object value, Variable variable, TyonContext_Dehydration context)
        {
            return new TyonValue_ExternalAddress(CalculateAddress(value, variable, context), context);
        }

        public override object ResolveTyonAddress(TyonAddress address, Variable variable, TyonContext_Hydration context)
        {
            return ResolveAddress(address.GetAddressValue(context), variable, context);
        }
    }
}
