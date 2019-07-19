using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public abstract class TyonBridge : TyonSettingsComponent
    {
        public abstract bool IsCompatible(Variable variable);

        public abstract TyonValue CreateTyonValue(VariableInstance variable, TyonDehydrater dehydrater);
        public abstract object ResolveTyonAddress(TyonAddress address, Variable variable, TyonHydrater hydrater);
    }
}
