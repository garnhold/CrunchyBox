using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonDesignatedVariableProvider_Manual : TyonDesignatedVariableProvider
    {
        private Dictionary<Type, List<Variable>> all_variables;

        public TyonDesignatedVariableProvider_Manual(IEnumerable<Variable> vs)
        {
            all_variables = vs.ToMultiDictionary(v => v.GetDeclaringType());
        }

        public TyonDesignatedVariableProvider_Manual(params Variable[] vs) : this((IEnumerable<Variable>)vs) { }

        public override IEnumerable<Variable> GetDesignatedVariables(Type type)
        {
            return all_variables.GetAllAtKeys(
                type.GetTypeAndAllBaseTypesAndInterfaces(DetailDirection.SpecificToBasic)
            );
        }
    }
}
