using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonDesignatedVariableProvider_Propertys_Public : TyonDesignatedVariableProvider_Propertys
    {
        static public readonly TyonDesignatedVariableProvider_Propertys_Public INSTANCE = new TyonDesignatedVariableProvider_Propertys_Public();

        private TyonDesignatedVariableProvider_Propertys_Public() { }

        protected override Filterer<PropertyInfo> GetPropertyInfoFilterer(Type type)
        {
            return Filterer_PropertyInfo.IsGetPublic();
        }
    }
}
