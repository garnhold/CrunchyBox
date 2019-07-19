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
        protected abstract object CalculateAddress(VariableInstance variable, TyonDehydrater dehydrater);
        protected abstract object ResolveAddress(object address, Variable variable, TyonHydrater hydrater);

        public override TyonValue CreateTyonValue(VariableInstance variable, TyonDehydrater dehydrater)
        {
            return new TyonValue_ExternalAddress(CalculateAddress(variable, dehydrater), dehydrater);
        }

        public override object ResolveTyonAddress(TyonAddress address, Variable variable, TyonHydrater hydrater)
        {
            return ResolveAddress(address.GetAddressValue(hydrater), variable, hydrater);
        }
    }
}
