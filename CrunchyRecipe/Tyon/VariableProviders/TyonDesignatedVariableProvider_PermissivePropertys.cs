using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class TyonDesignatedVariableProvider_PermissivePropertys : TyonDesignatedVariableProvider
    {
        protected abstract Filterer<PropertyInfo> GetPropertyInfoFilterer(Type type);

        public override IEnumerable<Variable> GetDesignatedVariables(Type type)
        {
            return type.GetFilteredInstancePropertys(GetPropertyInfoFilterer(type))
                .Convert(p => p.CreatePermissiveVariable());
        }
    }
}
