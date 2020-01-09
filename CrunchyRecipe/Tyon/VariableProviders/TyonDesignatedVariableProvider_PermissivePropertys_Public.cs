using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
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
