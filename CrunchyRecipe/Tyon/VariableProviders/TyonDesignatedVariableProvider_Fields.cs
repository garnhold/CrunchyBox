using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public abstract class TyonDesignatedVariableProvider_Fields : TyonDesignatedVariableProvider
    {
        protected abstract Filterer<FieldInfo> GetFieldInfoFilterer(Type type);

        public override IEnumerable<Variable> GetDesignatedVariables(Type type)
        {
            return type.GetFilteredInstanceFields(GetFieldInfoFilterer(type))
                .Convert(f => f.CreateVariable());
        }
    }
}
