using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public abstract class TyonDesignatedVariableProvider_Propertys : TyonDesignatedVariableProvider
    {
        protected abstract Filterer<PropertyInfo> GetPropertyInfoFilterer(Type type);

        public override IEnumerable<Variable> GetDesignatedVariables(Type type)
        {
            return type.GetFilteredInstancePropertys(GetPropertyInfoFilterer(type))
                .Convert(p => p.CreateVariable());
        }
    }
}
