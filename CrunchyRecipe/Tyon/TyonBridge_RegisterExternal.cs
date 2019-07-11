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
        public override TyonValue CreateTyonValue(VariableInstance variable, TyonContext_Dehydration context)
        {
            return new TyonValue_ExternalAddress(context.RegisterExternalObject(variable.GetContents()), context);
        }

        public override object ResolveTyonAddress(TyonAddress address, Variable variable, TyonContext_Hydration context)
        {
            return context.ResolveRegisteredExternalAddress(address.GetAddressValue(context));
        }
    }
}
