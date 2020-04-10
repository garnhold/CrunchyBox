using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonSettings_General : TyonSettings
    {
        static public readonly TyonSettings_General INSTANCE = new TyonSettings_General();

        private TyonSettings_General() : base(
            TyonDesignatedVariableProvider_Fields_Marked<TyonFieldAttribute>.INSTANCE,

            TyonDesignatedVariableProvider_Fields_Public.INSTANCE,
            TyonDesignatedVariableProvider_PermissivePropertys_Public.INSTANCE
        ) { }
    }
}
