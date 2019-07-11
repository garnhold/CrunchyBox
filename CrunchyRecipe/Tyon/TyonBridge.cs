using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public abstract class TyonBridge : TyonSerializationComponent
    {
        public abstract bool IsCompatible(Variable variable);

        public abstract TyonValue CreateTyonValue(VariableInstance variable, TyonContext_Dehydration context);
        public abstract object ResolveTyonAddress(TyonAddress address, Variable variable, TyonContext_Hydration context);
    }
}
