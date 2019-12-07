using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
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
