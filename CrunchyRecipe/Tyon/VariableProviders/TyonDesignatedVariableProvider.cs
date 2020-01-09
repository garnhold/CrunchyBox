using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class TyonDesignatedVariableProvider : TyonSettingsComponent
    {
        public abstract IEnumerable<Variable> GetDesignatedVariables(Type type);
    }
}
