using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public abstract class TyonBridge_RegisterExternal : TyonBridge
    {
        public override TyonValue CreateTyonValue(VariableInstance variable, TyonDehydrater dehydrater)
        {
            return new TyonValue_ExternalAddress(dehydrater.RegisterExternalObject(variable.GetContents()), dehydrater);
        }

        public override object ResolveTyonAddress(TyonAddress address, Variable variable, TyonHydrater hydrater)
        {
            return hydrater.ResolveRegisteredExternalAddress(address.GetAddressValue(hydrater));
        }
    }
}
