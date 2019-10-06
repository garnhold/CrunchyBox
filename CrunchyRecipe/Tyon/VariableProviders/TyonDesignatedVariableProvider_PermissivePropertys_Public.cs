using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonDesignatedVariableProvider_PermissivePropertys_Public : TyonDesignatedVariableProvider_PermissivePropertys
    {
        static public readonly TyonDesignatedVariableProvider_PermissivePropertys_Public INSTANCE = new TyonDesignatedVariableProvider_PermissivePropertys_Public();

        private TyonDesignatedVariableProvider_PermissivePropertys_Public() { }

        protected override Filterer<PropertyInfo> GetPropertyInfoFilterer(Type type)
        {
            return Filterer_PropertyInfo.IsGetPublic();
        }
    }
}
